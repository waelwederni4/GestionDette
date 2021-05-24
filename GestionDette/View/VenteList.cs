using Controleur;
using Model;
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
    public partial class VenteList : Form
    {
        Model.Client client;
        List<Vente> ventes;
        bool enable;
        public VenteList(Model.Client client)
        {
            enable = true;
            this.client = client;
            InitializeComponent();
        }
        public VenteList()
        {
            enable = false;
            this.client = null;
            InitializeComponent();
        }

        private void VenteList_Load(object sender, EventArgs e)
        {
            DataGridViewVente.AutoGenerateColumns = false;
            DataGridViewVente.DataSource = null;
            DataGridViewVente.Rows.Clear();
            using (ContextBase db = new ContextBase())
            {
                if (client != null)
                {
                    DataGridViewVente.DataSource = db.Ventes.Where(v => v.IDClient == client.IDClient).ToList();
                }
                else
                {
                    DataGridViewVente.DataSource = db.Ventes.ToList();
                }
                
            }
        }

        private void DataGridViewVente_DoubleClick(object sender, EventArgs e)
        {
            if (enable)
            {
                if (this.DataGridViewVente.RowCount != 0 && this.DataGridViewVente.CurrentRow.Index != -1)
                {
                    int index = Convert.ToInt32(this.DataGridViewVente.CurrentRow.Cells[0].Value);
                    using (ContextBase db = new ContextBase())
                    {
                        Model.Vente vente = db.Ventes.Where(c => c.IDVente == index).FirstOrDefault();
                        (System.Windows.Forms.Application.OpenForms["Caisse"] as Caisse).GetList(vente);
                    }
                }
            }
        }
    }
}
