using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controleur;
using System.Windows.Forms;

namespace View
{
    public partial class ListClient : Form
    {
        string text;
        bool enable;
        public ListClient(bool enable)
        {
            this.enable = enable;
            InitializeComponent();
        }
        public ListClient(bool enable, string text)
        {
            this.enable = enable;
            this.text = text;
            InitializeComponent();
        }

        private void ListClient_Load(object sender, EventArgs e)
        {
             
            using (ContextBase db = new ContextBase())
            {
                guna2DataGridView1.AutoGenerateColumns = false;
               
                if (string.IsNullOrWhiteSpace(text))
                {
                    if (db.Clients.ToList() != null)
                        guna2DataGridView1.DataSource = db.Clients.ToList();
                }
                else
                {
                    if (db.Clients.Where(c => c.nomClient.Contains(text) || c.prenomClient.Contains(text)).ToList() != null)
                        guna2DataGridView1.DataSource = db.Clients.Where(c => c.nomClient.Contains(text) || c.prenomClient.Contains(text)).ToList();
                }
            }
           
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (enable) {
                if (this.guna2DataGridView1.RowCount != 0 && this.guna2DataGridView1.CurrentRow.Index != -1)
                {
                    Model.Client client;
                    int index = Convert.ToInt32(this.guna2DataGridView1.CurrentRow.Cells[1].Value);
                    using (ContextBase db = new ContextBase())
                    {
                        client = db.Clients.Where(c => c.IDClient == index).FirstOrDefault();
                    }
                    if (!HasNotVentes(client))
                    {
                        if (System.Windows.Forms.Application.OpenForms["Dashbord"] != null)
                        {
                            (System.Windows.Forms.Application.OpenForms["Dashbord"] as Dashbord).ContainerCaisse(client);
                        }
                    }
                    else
                    {
                        if (IsFormOpen(typeof(AlertDelete)) != null)
                        {
                            IsFormOpen(typeof(AlertDelete)).Close();
                        }
                        AlertDelete alertDelete = new AlertDelete("Le Client " + client.nomClient + " " + client.prenomClient + " n'a pas des achats");
                        alertDelete.ShowDialog();
                    }
                }
            }
        }
        public Form IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return form;
            return null;
        }
        private bool HasNotVentes(Model.Client  client)
        {
            using(ContextBase db=new ContextBase())
            {
               return IsEmpty(db.Ventes.Where(v => v.IDClient == client.IDClient).ToList());
            }
        }
        public static bool IsEmpty<T>(List<T> list)
        {
            if (list == null)
            {
                return true;
            }

            return list.Count == 0;
        }
    }
}
