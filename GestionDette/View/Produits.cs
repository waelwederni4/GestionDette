using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Controleur;
using Model;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace View
{
    public partial class Produits : Form
    {
        List<Produit> produits = new List<Produit>();
        Produit produitModif;
        int indexFirst = 0;
        public Produits()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (produitModif != null)
            {
                if (IsFormOpen(typeof(GestionProduit)) != null)
                {
                    IsFormOpen(typeof(GestionProduit)).Close();
                }
                GestionProduit gc = new GestionProduit(produitModif);
                gc.ShowDialog();
            }
        }
        public void Loader()
        {
            indexFirst = 0;
            using (ContextBase db = new ContextBase())
            {
                guna2DataGridView1.AutoGenerateColumns = false;
                if (db.Produits.ToList() != null)
                    guna2DataGridView1.DataSource = db.Produits.ToList();
                guna2DataGridView1.Refresh();
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(GestionProduit)) != null)
            {
                IsFormOpen(typeof(GestionProduit)).Close();
            }
            GestionProduit gc = new GestionProduit();
            gc.ShowDialog();
        }
        public Form IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return form;
            return null;
        }
        private void Produits_Load(object sender, EventArgs e)
        {
            Loader();
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.guna2DataGridView1.RowCount != 0 && this.guna2DataGridView1.CurrentRow.Index != -1)
            {
                if (this.guna2DataGridView1.CurrentRow.Cells[5].Value == null)
                {
                    this.guna2DataGridView1.CurrentRow.Cells[5].Value = Properties.Resources.select;
                    int index = Convert.ToInt32(this.guna2DataGridView1.CurrentRow.Cells[1].Value);
                    using (ContextBase db = new ContextBase())
                    {
                        Produit clt = db.Produits.Where(c => c.IDProduit == index).FirstOrDefault();
                        if (indexFirst == 0) indexFirst = clt.IDProduit;
                        produits.Add(clt);
                    }
                }
                else
                {
                    this.guna2DataGridView1.CurrentRow.Cells[5].Value = null;
                    int index = Convert.ToInt32(this.guna2DataGridView1.CurrentRow.Cells[1].Value);
                    using (ContextBase db = new ContextBase())
                    {
                        Produit clt = db.Produits.Where(c => c.IDProduit == index).FirstOrDefault();
                        if (indexFirst != 0) indexFirst = 0;
                        produits.Remove(clt);
                    }
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (produits.Count != 0)
                {
                    using (ContextBase db = new ContextBase())
                    {
                        foreach (Produit c in produits)
                        {
                            var entry = db.Entry(c);
                            if (entry.State == System.Data.Entity.EntityState.Detached) db.Produits.Attach(c);
                            
                            entry.State = System.Data.Entity.EntityState.Deleted;
                        }
                        db.Produits.RemoveRange(produits);
                        db.ClearID("Produit", 0);
                        db.SaveChanges();
                        produits.Clear();
                        Loader();
                    }
                }
            }
            catch (Exception ex) { 
            
            }
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            if (this.guna2DataGridView1.RowCount != 0 && this.guna2DataGridView1.CurrentRow.Index != -1)
            {
                int index = Convert.ToInt32(this.guna2DataGridView1.CurrentRow.Cells[1].Value);
                using (ContextBase db = new ContextBase())
                {
                    Produit clt = db.Produits.Where(c => c.IDProduit == index).FirstOrDefault();
                    produitModif = clt;
                }
            }
            else
            {
                produitModif = null;
            }
        }
    }
}
