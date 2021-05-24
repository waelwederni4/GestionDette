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
    public partial class CategorieList : Form
    {
        public CategorieList()
        {
            InitializeComponent();
        }

        private void CategorieList_Load(object sender, EventArgs e)
        {
            DataGridViewVente.AutoGenerateColumns = false;
            DataGridViewVente.DataSource = null;
            DataGridViewVente.Rows.Clear();
            using (ContextBase db = new ContextBase())
            {
               
                DataGridViewVente.DataSource = db.Categories.ToList();

            }
        }
    }
}
