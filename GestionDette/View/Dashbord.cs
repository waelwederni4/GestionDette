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
    public partial class Dashbord : Form
    {
        Magasin magasin;
        bool exit = true;
        public Dashbord()
        {
            InitializeComponent();
        }

        private void Loding_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            guna2ShadowForm1.SetShadowForm(this);
            using(ContextBase db=new ContextBase())
            {
                magasin = db.Magasin.Where(m => m.IDMagasin == 1).FirstOrDefault();
                if (IsFormOpen(typeof(Acceuil)) != null)
                    {
                        IsFormOpen(typeof(Acceuil)).Close();
                    }
                    Getcontainer(new Acceuil(), acceuilBtn);
            }
            if (magasin.Image != null) guna2PictureBox1.Image = ByteToImage(magasin.Image);
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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(Acceuil)) != null)
            {
                IsFormOpen(typeof(Acceuil)).Close();
            }
            Getcontainer(new Acceuil(),sender);
        }
        public void HideF()
        {
            exit = false;
            if (IsFormOpen(typeof(Form1)) != null)
            {
                IsFormOpen(typeof(Form1)).Close();
            }
            MagazinFirst f = new MagazinFirst();
            f.Show();
            this.Hide();
        }
        public void GetDash()
        {
            if (IsFormOpen(typeof(Acceuil)) != null)
            {
                IsFormOpen(typeof(Acceuil)).Close();
            }
            Getcontainer(new Acceuil(), acceuilBtn);
        }
        private void Getcontainer(object _form, object sender)
        {
            ((Guna.UI2.WinForms.Guna2Button)sender).Checked = true;
            if (container.Controls.Count > 0) container.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            container.Controls.Add(fm);
            container.Tag = fm;
            fm.Show();

        }
        public void ContainerCaisse(Model.Client client)
        {
            if (IsFormOpen(typeof(Caisse)) != null)
            {
                IsFormOpen(typeof(Caisse)).Close();
            }
            removeClientBtn.Checked = true;
            if (container.Controls.Count > 0) container.Controls.Clear();
            Caisse caisse = new Caisse(client);
            caisse.TopLevel = false;
            caisse.FormBorderStyle = FormBorderStyle.None;
            caisse.Dock = DockStyle.Fill;
            container.Controls.Add(caisse);
            container.Tag = caisse;
            caisse.Show();

        }
        public void GetList()
        {
            if (IsFormOpen(typeof(ListClient)) != null)
            {
                IsFormOpen(typeof(ListClient)).Close();
            }
            Getcontainer(new ListClient(true), removeClientBtn);
        }
        public void ContainerDette(Model.Client client)
        {
            if (IsFormOpen(typeof(Shop)) != null)
            {
                IsFormOpen(typeof(Shop)).Close();
            }
            acceuilBtn.Checked = true;
            if (container.Controls.Count > 0) container.Controls.Clear();
            Shop shop = new Shop(client);
            shop.TopLevel = false;
            shop.FormBorderStyle = FormBorderStyle.None;
            shop.Dock = DockStyle.Fill;
            container.Controls.Add(shop);
            container.Tag = shop;
            shop.Show();
        }

        private void acceuilBtn_MouseHover(object sender, EventArgs e)
        {
           addClientBtn.Checked = false;
            removeClientBtn.Checked = false;
            editClientBtn.Checked = false;
        }

        private void addClientBtn_MouseHover(object sender, EventArgs e)
        {
            acceuilBtn.Checked = false;
            removeClientBtn.Checked = false;
            editClientBtn.Checked = false;
        }

        private void removeClientBtn_MouseHover(object sender, EventArgs e)
        {
            addClientBtn.Checked = false;
            acceuilBtn.Checked = false;
            editClientBtn.Checked = false;
        }

        private void editClientBtn_MouseHover(object sender, EventArgs e)
        {
            addClientBtn.Checked = false;
            removeClientBtn.Checked = false;
            acceuilBtn.Checked = false;
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(Client)) != null)
            {
                IsFormOpen(typeof(Client)).Close();
            }
            Getcontainer(new Client(), sender);
        }

        private void editClientBtn_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(Produits)) != null)
            {
                IsFormOpen(typeof(Produits)).Close();
            }
            Getcontainer(new Produits(), sender);    
        }

        private void removeClientBtn_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(ListClient))!=null)
            {
                IsFormOpen(typeof(ListClient)).Close();
            }
            Getcontainer(new ListClient(true), sender);
        }
        public Form IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return form;
            return null;
        }
        private void Dashbord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(exit)
            System.Windows.Forms.Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(Parametre)) != null)
            {
                IsFormOpen(typeof(Parametre)).Close();
            }
            Getcontainer(new Parametre(), sender);
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        public void ContainerSearch(string text)
        {
            if (IsFormOpen(typeof(ListClient)) != null)
            {
                IsFormOpen(typeof(ListClient)).Close();
            }
            acceuilBtn.Checked = true;
            if (container.Controls.Count > 0) container.Controls.Clear();
            ListClient listClient = new ListClient(true,text) ;
            listClient.TopLevel = false;
            listClient.FormBorderStyle = FormBorderStyle.None;
            listClient.Dock = DockStyle.Fill;
            container.Controls.Add(listClient);
            container.Tag = listClient;
            listClient.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = guna2TextBox1.Text;
            if (string.IsNullOrWhiteSpace(text)) {
                if (IsFormOpen(typeof(Acceuil)) != null)
                {
                    IsFormOpen(typeof(Acceuil)).Close();
                }
                Getcontainer(new Acceuil(), acceuilBtn);
            }
            else
            {
                    ContainerSearch(text);
            }
        }

        private void guna2Button5_MouseMove(object sender, MouseEventArgs e)
        {
            addClientBtn.Checked = false;
            removeClientBtn.Checked = false;
            acceuilBtn.Checked = false;
            editClientBtn.Checked = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
