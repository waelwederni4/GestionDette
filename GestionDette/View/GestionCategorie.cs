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
using System.Data.Entity.Migrations;

namespace View
{
    public partial class GestionCategorie : Form
    {
        Model.Categorie categorie = new Model.Categorie();
        public GestionCategorie()
        {
            InitializeComponent();
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            categorie.nomCategorie = nom.Text.Trim();
            try
            {
                using (ContextBase db = new ContextBase())
                {
                    db.Categories.AddOrUpdate(categorie);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (System.Windows.Forms.Application.OpenForms["GestionProduit"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["GestionProduit"] as GestionProduit).Loader();
            }
            this.Close();
        }

        private void GestionCategorie_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            CenterToParent();
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}
