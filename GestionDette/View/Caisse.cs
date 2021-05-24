using Controleur;
using Guna.UI2.WinForms;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Caisse : Form
    {
        Model.Client client;
        Vente vente { get; set; }
        bool Isvente = true;
        public Caisse(Model.Client client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void Caisse_Load(object sender, EventArgs e)
        {
            nomclient.Text = client.nomClient + " " + client.prenomClient;
            dette.Text = string.Format("{0} TND", client.detteClient);
            GetView();
        }

        private void backArrow_Click(object sender, EventArgs e)
        {
            if (!Isvente)
            {
                GetView();
            }
            else
            {
                (System.Windows.Forms.Application.OpenForms["Dashbord"] as Dashbord).GetList();
            }

        }
        public void GetView()
        {
            if (IsFormOpen(typeof(VenteList)) != null)
            {
                IsFormOpen(typeof(VenteList)).Close();
            }
            Isvente = true;
            if (viewPanel.Controls.Count > 0) viewPanel.Controls.Clear();
            VenteList fm = new VenteList(client);
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            viewPanel.Controls.Add(fm);
            viewPanel.Tag = fm;
            fm.Show();
            
        }
        public void GetList(Vente vente)
        {
            if (IsFormOpen(typeof(ProduitVList)) != null)
            {
                IsFormOpen(typeof(ProduitVList)).Close();
            }
            Isvente = false;
            if (viewPanel.Controls.Count > 0) viewPanel.Controls.Clear();
            ProduitVList fm = new ProduitVList(vente);
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            viewPanel.Controls.Add(fm);
            viewPanel.Tag = fm;
            fm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(cash.Text) && client.detteClient != 0.0) { 
            using (ContextBase db = new ContextBase()) {
                Magasin magasin = db.Magasin.Where(m => m.IDMagasin == client.IDMagasin).FirstOrDefault();
                magasin.revenuTotal +=Convert.ToDouble(cash.Text);
                client.detteClient -= Convert.ToDouble(cash.Text);
                db.Magasin.AddOrUpdate(magasin);
                db.Clients.AddOrUpdate(client);
                db.SaveChanges();
            }
            if (IsFormOpen(typeof(ImprimerFacture)) != null)
            {
                IsFormOpen(typeof(ImprimerFacture)).Close();
            }
            ImprimerFacture imprimerFacture = new ImprimerFacture(client, Convert.ToDouble(cash.Text));
            imprimerFacture.ShowDialog();
            }
            else
            {
                string text;
                if (string.IsNullOrWhiteSpace(cash.Text))
                {
                    text = "Cash ne peux pas être vide";
                }
                else
                {
                    text = "Client n'a pas de dettes";
                }
                if (IsFormOpen(typeof(AlertDelete)) != null)
                {
                    IsFormOpen(typeof(AlertDelete)).Close();
                }
                AlertDelete alertDelete = new AlertDelete(text);
                alertDelete.ShowDialog();
            }
        }
        public Form IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return form;
            return null;
        }
        private void cash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as Guna2TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
