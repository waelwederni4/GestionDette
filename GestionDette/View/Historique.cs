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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Historique : Form
    {
        public Historique()
        {
            InitializeComponent();
        }

        private void Historique_Load(object sender, EventArgs e)
        {

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
            using (ContextBase db = new ContextBase())
            {
                ExportCsv(db.Clients.ToList(), "clients");
            }
        }
       
        private void categoriesbtn_Click(object sender, EventArgs e)
        {
            using (ContextBase db = new ContextBase())
            {
                ExportCsv(db.Categories.ToList(), "categories");
            }
        }

        private void ventesbtn_Click(object sender, EventArgs e)
        {
            using (ContextBase db = new ContextBase())
            {
                ExportCsv(db.Ventes.ToList(), "ventes");
            }
        }

        private void produitbtn_Click(object sender, EventArgs e)
        {
            using (ContextBase db = new ContextBase())
            {
                ExportCsv(db.Produits.ToList(), "produits");
            }
        }

        private void ligneventesbtn_Click(object sender, EventArgs e)
        {
            using (ContextBase db = new ContextBase())
            {
                ExportCsv(db.Ligneventes.ToList(), "Ligneventes");
            }
        }

        private void recuFacturesbtn_Click(object sender, EventArgs e)
        {
                using (ContextBase db = new ContextBase())
                {
                    ExportCsv(db.RecuFactures.ToList(), "RecuFactures");
                }   
        }
        public static void ExportCsv<T>(IEnumerable<T> genericList, string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var finalPath = Path.Combine(path, fileName+"-"+DateTime.Now.ToFileTime()+ ".csv");
            using (var writer = new StreamWriter(finalPath)) { 
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                    csv.WriteRecords(genericList);
            }
            }
            Process.Start(finalPath);
        }
    }
}
