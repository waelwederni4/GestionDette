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
using Model;

namespace View
{
    public partial class GestionClient : Form
    {
        Model.Client client = null;
        bool isUpdate = false;
        public GestionClient()
        {
            InitializeComponent();
        }
        public GestionClient(Model.Client client)
        {
            this.client = client;
            isUpdate = true;
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            client.IDMagasin = 1;
            client.detteClient = 0.0;
            client.nomClient = nom.Text.Trim();
            client.prenomClient = prenom.Text.Trim();
            client.adresseClient = adress.Text.Trim();
            client.numTelClient = numTel.Text.Trim();
            try { 
            using (ContextBase db = new ContextBase())
            {
                Magasin magasin = db.Magasin.Where(m => m.IDMagasin == 1).FirstOrDefault(); magasin.nbClient++;
                db.Magasin.AddOrUpdate(magasin);
                db.Clients.AddOrUpdate(client);
                db.SaveChanges();
            }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            (System.Windows.Forms.Application.OpenForms["Client"] as Client).Loader();
            this.Close();
        }

        private void GestionClient_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            CenterToParent();
            guna2ShadowForm1.SetShadowForm(this);
            if (client == null)
            {
                client = new Model.Client();
                detteTv.Visible = false;
                dette.Visible = false;
            }
            else {
                nom.Text = client.nomClient;
                adress.Text = client.adresseClient;
                prenom.Text = client.prenomClient;
                numTel.Text = client.numTelClient;
                detteTv.Visible = true;
                dette.Text = ""+client.detteClient;
            }
        }
    }
}
