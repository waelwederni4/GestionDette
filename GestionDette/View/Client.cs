using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Controleur;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Data.Entity.Migrations;

namespace View
{
    public partial class Client : Form
    {
        List<Model.Client> clients=new List<Model.Client>();
        Model.Client clientModif;
        int indexFirst = 0;
        int indexClick;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            Loader();
        }
        public void Loader()
        {
            indexFirst = 0;
            using (ContextBase db = new ContextBase())
            {
                guna2DataGridView1.AutoGenerateColumns = false;
                if (db.Clients.ToList() != null)
                    guna2DataGridView1.DataSource = db.Clients.ToList();
                guna2DataGridView1.Refresh();
            }
        }
        public bool DeleteClient { get; set; }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GestionClient gc=new GestionClient();
            gc.ShowDialog();
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.guna2DataGridView1.RowCount != 0 && this.guna2DataGridView1.CurrentRow.Index != -1) { 
            if (this.guna2DataGridView1.CurrentRow.Cells[7].Value==null)
            {
                    indexClick = this.guna2DataGridView1.CurrentRow.Index;
                    int index =Convert.ToInt32(this.guna2DataGridView1.CurrentRow.Cells[1].Value);
                    using (ContextBase db = new ContextBase())
                    {
                        Model.Client clt = db.Clients.AsNoTracking().Where(c => c.IDClient == index).FirstOrDefault();
                        if (indexFirst == 0) indexFirst = index - 1;
                        if (HaveVente(clt))
                        {
                            if (IsFormOpen(typeof(AlertDelete)) != null)
                            {
                                IsFormOpen(typeof(AlertDelete)).Close();
                            }
                            AlertDelete alertDelete = new AlertDelete(clt);
                            alertDelete.ShowDialog();
                        }
                        else
                        {
                            AddClient(clt);
                        }   
                    }
            }
            else
            {
                this.guna2DataGridView1.CurrentRow.Cells[7].Value = null;
                    int index = Convert.ToInt32(this.guna2DataGridView1.CurrentRow.Cells[1].Value);
                    using (ContextBase db = new ContextBase())
                    { 
                        Model.Client clt = db.Clients.AsNoTracking().Where(c => c.IDClient == index).FirstOrDefault();
                        if (indexFirst != 0) indexFirst =0;
                        clients.Remove(clt);
                    }
                }
            }
        }
        public void AddClient(Model.Client client)
        {
            clients.Add(client);
            this.guna2DataGridView1.Rows[indexClick].Cells[7].Value = Properties.Resources.select;
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (clientModif != null) {
                if (IsFormOpen(typeof(GestionClient)) != null)
                {
                    IsFormOpen(typeof(GestionClient)).Close();
                }
                GestionClient gc = new GestionClient(clientModif);
                gc.ShowDialog();
            }
        }
        public Form IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return form;
            return null;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (clients.Count != 0)
            {
                using (ContextBase db = new ContextBase())
                {
                    Magasin magasin = db.Magasin.Where(m => m.IDMagasin == 1).FirstOrDefault();
                    foreach (Model.Client c in clients) {
                          var entry = db.Entry(c);
                          if (entry.State == System.Data.Entity.EntityState.Detached) db.Clients.Attach(c);
                          entry.State = System.Data.Entity.EntityState.Deleted;
                        magasin.nbClient--;
                    }
                    db.Magasin.AddOrUpdate(magasin);
                    db.Clients.RemoveRange(clients);
                    if (clients.Count == 1)
                        db.ClearID("Client",0);
                    else
                        db.ClearID("Client", indexFirst);
                    db.SaveChanges();
                    clients.Clear();
                    Loader();
                }
            }
        }

        private bool HaveVente(Model.Client c)
        {
            bool check=false;
            using (ContextBase db = new ContextBase())
            {
                var ventes = db.Ventes.Where(cl => cl.IDClient == c.IDClient).ToList();
                if (ventes != null) check = true; 
            }
            return check;
        }
        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            if (this.guna2DataGridView1.RowCount!=0 && this.guna2DataGridView1.CurrentRow.Index != -1)
            {
                int index = Convert.ToInt32(this.guna2DataGridView1.CurrentRow.Cells[1].Value);
                using (ContextBase db = new ContextBase())
                {
                    Model.Client clt = db.Clients.Where(c => c.IDClient == index).FirstOrDefault();
                    clientModif = clt; 
                }
            }
            else
            {
                clientModif = null;
            }
        }
    }
}
