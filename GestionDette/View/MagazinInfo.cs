using Controleur;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using Model;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace View
{
    public partial class MagazinInfo : Form
    {
        Magasin magasin;
        String imageLocation;
        bool isUpdateImg = false;

        public MagazinInfo()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ValideDelete msgBox = new ValideDelete("êtes-vous sûr de supprimer votre magazin");
            msgBox.ShowDialog();
        }
        public void VideMagasin()
        {
            using (ContextBase db = new ContextBase())
            {
                magasin = db.Magasin.Where(m => m.IDMagasin == 1).FirstOrDefault();
                db.ClearID("Magasin", 0);
                db.Magasin.Remove(magasin);
                db.SaveChanges();
                (System.Windows.Forms.Application.OpenForms["Dashbord"] as Dashbord).HideF();
            }
        }
        public Form IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return form;
            return null;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            using (ContextBase db = new ContextBase())
            {
                ExportCsv(db.Magasin.ToList(), "Magasin");
            }
        }
        public static void ExportCsv<T>(IEnumerable<T> genericList, string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var finalPath = Path.Combine(path, fileName + "-" + DateTime.Now.ToFileTime() + ".csv");
            using (var writer = new StreamWriter(finalPath))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(genericList);
                }
            }
            Process.Start(finalPath);
        }

        private void MagazinInfo_Load(object sender, EventArgs e)
        {
            using (ContextBase db = new ContextBase())
            {
                magasin = db.Magasin.Where(m => m.IDMagasin == 1).FirstOrDefault();
            }
            if (magasin == null) magasin = new Magasin();
            else
            {
                nomMagasin.Text = magasin.nomMagasin;
                if(magasin.Image!=null)
                    guna2PictureBox1.Image = ByteToImage(magasin.Image);
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            using (ContextBase db = new ContextBase())
            {
                magasin.nomMagasin = nomMagasin.Text;
                if (isUpdateImg)
                {
                    FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader reader = new BinaryReader(stream);
                    magasin.Image = reader.ReadBytes((int)stream.Length);
                }
                db.Magasin.AddOrUpdate(magasin);
                db.SaveChanges();
            }
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Image Produit";
            //which type image format you want to upload in database. just add them.
            openFile.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFile.FilterIndex = 1;
            try
            {
                if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    if (openFile.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFile.FileName);
                        imageLocation = path;
                        isUpdateImg = true;
                        guna2PictureBox1.Image = new Bitmap(openFile.FileName);
                        guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
