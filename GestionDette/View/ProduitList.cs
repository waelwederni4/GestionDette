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
    public partial class ProduitList : Form
    {
        public ProduitList()
        {
            InitializeComponent();
        }

        private void ProduitList_Load(object sender, EventArgs e)
        {
            using (ContextBase db = new ContextBase())
            {
                DataGridViewProduits.AutoGenerateColumns = false;
                if (db.Produits.ToList() != null)
                    DataGridViewProduits.DataSource = db.Produits.ToList();
                DataGridViewProduits.Refresh();
            }
        }
    }
}
