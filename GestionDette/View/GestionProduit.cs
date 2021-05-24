using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Controleur;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity.Migrations;

namespace View
{
    public partial class GestionProduit : Form
    {
        Model.Produit produit = null;
        String imageLocation;
        bool isUpdate = false;
        bool isUpdateImg = false;
        public GestionProduit()
        {
            isUpdate = false;
            InitializeComponent();
        }
        public GestionProduit(Model.Produit produit)
        {
            this.produit = produit;
            isUpdate = true;
            InitializeComponent();
        }

        private void guna2PictureBox2_DoubleClick(object sender, EventArgs e)
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
                        guna2PictureBox2.Image = new Bitmap(openFile.FileName);
                        guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                //MessageBox.Show(ex.Message);
            }
        }

        private void GestionProduit_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            CenterToParent();
            guna2ShadowForm1.SetShadowForm(this);
            Loader();
            if (!isUpdate)
            {
                produit = new Model.Produit();
            }
            else
            {
                nom.Text = produit.nomProduit;
                prix.Text = ""+produit.prixProduit;
                guna2PictureBox2.Image = ByteToImage(produit.Image);
                using (ContextBase db = new ContextBase())
                {
                  guna2ComboBox1.SelectedText = db.Categories.Where(c => c.IDCategorie == produit.IDCategorie).Select(cat => cat.nomCategorie).FirstOrDefault();
                }
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
        public void Loader()
        {
            List<string> vs = new List<string>();
            using (ContextBase db = new ContextBase())
            {
                if (db.Categories.ToList() != null) 
                    guna2ComboBox1.DataSource= db.Categories.Select(cat => cat.nomCategorie).ToList(); 

            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(GestionCategorie)) != null)
            {
                IsFormOpen(typeof(GestionCategorie)).Close();
            }
            GestionCategorie gc = new GestionCategorie();
            gc.ShowDialog();
        }
        public Form IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return form;
            return null;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selected = this.guna2ComboBox1.GetItemText(this.guna2ComboBox1.SelectedItem);
                produit.prixProduit = double.Parse(prix.Text.Trim(), System.Globalization.CultureInfo.InvariantCulture); ;
                produit.nomProduit = nom.Text.Trim();
                produit.StrCategorie = selected;
                if (isUpdateImg) { 
                FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(stream);
                produit.Image = reader.ReadBytes((int)stream.Length);
                }
                using (ContextBase db = new ContextBase())
                {
                    produit.IDCategorie = db.Categories.Where(c => c.nomCategorie == selected).Select(c => c.IDCategorie).FirstOrDefault();
                    db.Produits.AddOrUpdate(produit);
                    db.SaveChanges();
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (System.Windows.Forms.Application.OpenForms["Produits"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Produits"] as Produits).Loader();
            }
            this.Close();
        }

        private void prix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
