using Controleur;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class MagazinFirst : Form
    {
        Magasin magasin;
        String imageLocation;
        public MagazinFirst()
        {
            InitializeComponent();
        }

        private void MagazinFirst_Load(object sender, EventArgs e)
        {
            CenterToParent();
            guna2ShadowForm1.SetShadowForm(this);
            magasin = new Magasin();
            using(ContextBase db=new ContextBase())
            {
                db.ClearID("Magasin", 0);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (ContextBase db = new ContextBase())
            {
                magasin.nomMagasin = nomMagasin.Text;
                magasin.detteTotal = 0.0;
                magasin.nbClient = 0;
                magasin.revenuTotal = 0.0;
                if (imageLocation != null)
                {
                    FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader reader = new BinaryReader(stream);
                    magasin.Image = reader.ReadBytes((int)stream.Length);
                }
                db.Magasin.Add(magasin);
                db.SaveChanges();
                Dashbord p = new Dashbord();
                p.Show();
                this.Hide();
            }
        }

        private void guna2PictureBox1_DoubleClick(object sender, EventArgs e)
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

        private void MagazinFirst_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
