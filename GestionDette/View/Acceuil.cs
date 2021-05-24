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
    public partial class Acceuil : Form
    {
        List<Model.Client> list=null;
        int nbC;
        public Acceuil()
        {
            InitializeComponent();
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
           
            using (ContextBase db = new ContextBase())
            {
                Magasin magasin = db.Magasin.Where(m => m.IDMagasin == 1).FirstOrDefault();
                nbClient.Text = string.Format("{0}",magasin.nbClient);
                dettetv.Text = string.Format("{0} TND", magasin.detteTotal);
                revenuTotal.Text = string.Format("{0} TND", magasin.revenuTotal);
                guna2DataGridView1.AutoGenerateColumns = false;
                if (db.Clients.ToList() != null)
                    guna2DataGridView1.DataSource = db.Clients.ToList();
            }
        }
       
        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.guna2DataGridView1.RowCount != 0 && this.guna2DataGridView1.CurrentRow.Index != -1)
            {
                Model.Client client;
                int index = Convert.ToInt32(this.guna2DataGridView1.CurrentRow.Cells[1].Value);
                using (ContextBase db = new ContextBase())
                {
                    client = db.Clients.Where(c => c.IDClient == index).FirstOrDefault();
                }
                 (System.Windows.Forms.Application.OpenForms["Dashbord"] as Dashbord).ContainerDette(client);
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
