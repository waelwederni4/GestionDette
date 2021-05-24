using Controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class SupprissionDonnee : Form
    {
        public SupprissionDonnee()
        {
            InitializeComponent();
        }

        private void clientsbtn_MouseHover(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(ListClient)) != null)
            {
                IsFormOpen(typeof(ListClient)).Close();
            }
            Getcontainer(new ListClient(false));
        }

        private void categoriesbtn_MouseHover(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(CategorieList)) != null)
            {
                IsFormOpen(typeof(CategorieList)).Close();
            }
            Getcontainer(new CategorieList());
        }

        private void ventesbtn_MouseHover(object sender, EventArgs e)
        {
           if (IsFormOpen(typeof(VenteList)) != null)
            {
                IsFormOpen(typeof(VenteList)).Close();
            }
            Getcontainer(new VenteList());
        }

        private void produitbtn_MouseHover(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(ProduitList)) != null)
            {
                IsFormOpen(typeof(ProduitList)).Close();
            }
            Getcontainer(new ProduitList());
        }

        private void ligneventesbtn_MouseHover(object sender, EventArgs e)
        {
             if (IsFormOpen(typeof(LigneVenteList)) != null)
             {
                 IsFormOpen(typeof(LigneVenteList)).Close();
             }
             Getcontainer(new LigneVenteList());
        }

        private void recuFacturesbtn_MouseHover(object sender, EventArgs e)
        {
          if (IsFormOpen(typeof(RecuFactureList)) != null)
            {
                IsFormOpen(typeof(RecuFactureList)).Close();
            }
            Getcontainer(new RecuFactureList());
        }
        private void Getcontainer(object _form)
        {
            if (container.Controls.Count > 0) container.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            container.Controls.Add(fm);
            container.Tag = fm;
            fm.Show();
        }
        public Form IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return form;
            return null;
        }

        private void clientsbtn_Click(object sender, EventArgs e)
        {
            ValideDelete msgBox = new ValideDelete("êtes-vous sûr de supprimer tous les clients",0);
            msgBox.ShowDialog();
        }

        private void categoriesbtn_Click(object sender, EventArgs e)
        {
            ValideDelete msgBox = new ValideDelete("êtes-vous sûr de supprimer tous les categories",1);
            msgBox.ShowDialog();
        }

        private void ventesbtn_Click(object sender, EventArgs e)
        {
            ValideDelete msgBox = new ValideDelete("êtes-vous sûr de supprimer les ventes",2);
            msgBox.ShowDialog();
        }

        private void produitbtn_Click(object sender, EventArgs e)
        {
            ValideDelete msgBox = new ValideDelete("êtes-vous sûr de supprimer tous les produits",3);
            msgBox.ShowDialog();
        }

        private void ligneventesbtn_Click(object sender, EventArgs e)
        {
            ValideDelete msgBox = new ValideDelete("êtes-vous sûr de supprimer lignes ventes",4);
            msgBox.ShowDialog();
        }

        private void recuFacturesbtn_Click(object sender, EventArgs e)
        {
            ValideDelete msgBox = new ValideDelete("êtes-vous sûr de supprimer les recus du factures",5);
            msgBox.ShowDialog();
        }

        private void tousbtn_Click(object sender, EventArgs e)
        {
            ValideDelete msgBox = new ValideDelete("êtes-vous sûr de supprimer tous les donneés",6);
            msgBox.ShowDialog();
        }
        public void Vider(int index)
        {
            switch (index)
            {
                case 0:
                    using (ContextBase db = new ContextBase())
                    {
                        db.Clients.RemoveRange(db.Clients.AsEnumerable());
                        db.ClearID("Client", 0);
                        db.SaveChanges();
                    }
                    if (IsFormOpen(typeof(ListClient)) != null)
                    {
                        IsFormOpen(typeof(ListClient)).Close();
                    }
                    Getcontainer(new ListClient(false));
                    break;
                case 1:
                    using (ContextBase db = new ContextBase())
                    {
                        db.Categories.RemoveRange(db.Categories.AsEnumerable());
                        db.ClearID("Categorie", 0);
                        db.SaveChanges();
                    }
                    if (IsFormOpen(typeof(CategorieList)) != null)
                    {
                        IsFormOpen(typeof(CategorieList)).Close();
                    }
                    Getcontainer(new CategorieList());
                    break;
                case 2:
                    using (ContextBase db = new ContextBase())
                    {
                        db.Ventes.RemoveRange(db.Ventes.AsEnumerable());
                        db.ClearID("Vente", 0);
                        db.SaveChanges();
                    }
                    if (IsFormOpen(typeof(VenteList)) != null)
                    {
                        IsFormOpen(typeof(VenteList)).Close();
                    }
                    Getcontainer(new VenteList());
                    break;
                case 3:
                    using (ContextBase db = new ContextBase())
                    {
                        db.Produits.RemoveRange(db.Produits.AsEnumerable());
                        db.ClearID("Produit", 0);
                        db.SaveChanges();
                    }
                    if (IsFormOpen(typeof(ProduitList)) != null)
                    {
                        IsFormOpen(typeof(ProduitList)).Close();
                    }
                    Getcontainer(new ProduitList());
                    break;
                case 4:
                    using (ContextBase db = new ContextBase())
                    {
                        db.Ligneventes.RemoveRange(db.Ligneventes.AsEnumerable());
                        db.ClearID("Lignevente", 0);
                        db.SaveChanges();
                    }
                    if (IsFormOpen(typeof(LigneVenteList)) != null)
                    {
                        IsFormOpen(typeof(LigneVenteList)).Close();
                    }
                    Getcontainer(new LigneVenteList());
                    break;
                case 5:
                    using (ContextBase db = new ContextBase())
                    {
                        db.RecuFactures.RemoveRange(db.RecuFactures.AsEnumerable());
                        db.ClearID("RecuFacture", 0);
                        db.SaveChanges();
                    }
                    if (IsFormOpen(typeof(RecuFactureList)) != null)
                    {
                        IsFormOpen(typeof(RecuFactureList)).Close();
                    }
                    Getcontainer(new RecuFactureList());
                    break;
                case 6:
                    using (ContextBase db = new ContextBase())
                    {
                        db.Categories.RemoveRange(db.Categories.AsEnumerable());
                        db.Ventes.RemoveRange(db.Ventes.AsEnumerable());
                        db.Clients.RemoveRange(db.Clients.AsEnumerable());
                        db.Produits.RemoveRange(db.Produits.AsEnumerable());
                        db.Ligneventes.RemoveRange(db.Ligneventes.AsEnumerable());
                        db.RecuFactures.RemoveRange(db.RecuFactures.AsEnumerable());
                        db.ClearID("Client", 0);
                        db.ClearID("Vente", 0);
                        db.ClearID("Categorie", 0);
                        db.ClearID("Lignevente", 0);
                        db.ClearID("Produit", 0);
                        db.ClearID("RecuFacture", 0);
                        db.SaveChanges();
                    }
                    break;
            }
        }
    }
}
