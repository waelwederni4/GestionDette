using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Model;
using Controleur;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Data.Entity.Migrations;

namespace View
{
    public partial class Shop : Form
    {
        Vente vente=new Vente();
        Model.Client client;
        List<Model.Lignevente> ligneventes;
        Nullable<double> prixTotal;
        public Shop(Model.Client client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            prixTotal = 0.0;
            tvTotal.Text = string.Format("{0} TND", prixTotal);
            ligneventes = new List<Model.Lignevente>();
            nomclient.Text = client.nomClient + " " + client.prenomClient;
            dette.Text = string.Format("{0} TND", client.detteClient);
            using (ContextBase db = new ContextBase())
            {
                vente.IDClient = client.IDClient;
                vente.dateVente = DateTime.Now;
                db.Ventes.Add(vente);
                db.SaveChanges();
                if (db.Produits.ToList() != null)
                    GenerateTable(db.Produits.ToList(),vente);
            }
        }
        private void GenerateTable(List<Produit> produits,Vente vente)
        {
            pane.Controls.Clear();
            pane.ColumnStyles.Clear();
            pane.RowStyles.Clear();
            pane.ColumnCount = 4;
            int i = 0;
            if (produits.Count % 4==0) { pane.RowCount = produits.Count / 4; }
            else
                pane.RowCount =Convert.ToInt32(produits.Count / 4)+1;

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < pane.RowCount; y++)
                {
                    if (i < produits.Count) { 
                    ProduitAchat produitAchat = new ProduitAchat(produits[i], vente);
                    pane.Controls.Add(produitAchat, x, y);
                    i++;
                    }
                }
            }
        }
        public void LoadPanne()
        {
            guna2DataGridView1.AutoGenerateColumns = false;
            guna2DataGridView1.DataSource = null;
            this.guna2DataGridView1.Rows.Clear();
            using (ContextBase db = new ContextBase())
            {
                if (db.Ligneventes.Where(l => l.IDVente == vente.IDVente).ToList() != null) { 
                ligneventes = db.Ligneventes.Where(l=>l.IDVente==vente.IDVente).ToList();
                    prixTotal = 0.0;
                    tvTotal.Text = string.Format("{0} TND", prixTotal);
                    foreach (Lignevente lignevente in ligneventes) {
                        Bitmap image;
                        if(lignevente.Produit.Image==null)
                            image = Properties.Resources.No_Image_Available;
                        else
                            image = ByteToImage(lignevente.Produit.Image);
                        guna2DataGridView1.Rows.Add(image, lignevente.Produit.nomProduit, lignevente.Produit.prixProduit, lignevente.QteProduit, lignevente.prixTotal);
                        prixTotal += lignevente.prixTotal;
                        tvTotal.Text = string.Format("{0} TND", prixTotal);
                    }
                }
               
            }
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RecuFacture recuFacture = new RecuFacture();
            recuFacture.IDVente = vente.IDVente;
            recuFacture.Totale = prixTotal;
            using (ContextBase db = new ContextBase())
            {
                db.RecuFactures.Add(recuFacture);
                client.detteClient += recuFacture.Totale;
                Magasin magasin = db.Magasin.Where(m => m.IDMagasin == 1).FirstOrDefault();
                magasin.detteTotal+= recuFacture.Totale;
                db.Magasin.AddOrUpdate(magasin);
                db.Clients.AddOrUpdate(client);
                db.SaveChanges();
            }
            if (IsFormOpen(typeof(ImprimerFacture)) != null)
            {
                IsFormOpen(typeof(ImprimerFacture)).Close();
            }
            ImprimerFacture imprimerFacture = new ImprimerFacture(vente);
            imprimerFacture.ShowDialog();
            (System.Windows.Forms.Application.OpenForms["Dashbord"] as Dashbord).GetDash();

        }
        public Form IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return form;
            return null;
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.guna2DataGridView1.RowCount != 0 && this.guna2DataGridView1.CurrentRow.Index != -1)
            {
                string nom = Convert.ToString(this.guna2DataGridView1.CurrentRow.Cells[1].Value);
                using(ContextBase db=new ContextBase())
                {
                    Produit produit = db.Produits.Where(p => p.nomProduit == nom).FirstOrDefault();
                    Lignevente lignevente = db.Ligneventes.Where(l => l.IDProduit == produit.IDProduit && l.IDVente == vente.IDVente).FirstOrDefault();
                    db.Ligneventes.Remove(lignevente);
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.CurrentRow.Index);
                    tvTotal.Text = string.Format("{0} TND", prixTotal-produit.prixProduit);
                    db.SaveChanges();
                }

            }
        }

        private void guna2DataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value = Properties.Resources.remove;
            }
        }

        private void guna2DataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value = Properties.Resources.unremove;
            }
        }
    }
}
