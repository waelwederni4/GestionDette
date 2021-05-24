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
using System.IO;
using System.Data.Entity.Migrations;

namespace View
{
    public partial class ProduitAchat : UserControl
    {
        Produit produit;
        Vente vente;
        Lignevente lignevente;
        public ProduitAchat(Produit produit,Vente vente)
        {
            this.produit = produit;
            this.vente = vente;
            InitializeComponent();
        }
        private void ProduitAchat_Load(object sender, EventArgs e)
        {
            nomProduit.Text = produit.nomProduit;
            prixproduit.Text = ""+produit.prixProduit;
            if(produit.Image!=null)
            imageProduit.Image = ByteToImage(produit.Image);
            else
            imageProduit.Image =Properties.Resources.No_Image_Available;
            imageProduit.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void imageProduit_DoubleClick(object sender, EventArgs e)
        {
            EffectVente();      
        }
        private void EffectVente()
        {
           
            using (ContextBase db = new ContextBase())
            {
                lignevente = db.Ligneventes.Where(l => l.IDProduit == produit.IDProduit && l.IDVente == vente.IDVente).FirstOrDefault();
                if (lignevente == null) { 
                    lignevente = new Lignevente();
                }
                else
                {
                    var entry = db.Entry(lignevente);
                    entry.State = System.Data.Entity.EntityState.Modified;
                }
                lignevente.IDProduit = produit.IDProduit;
                lignevente.IDVente = vente.IDVente;
                lignevente.QteProduit = Convert.ToInt32(qte.Value);
                lignevente.prixTotal = lignevente.QteProduit * produit.prixProduit;
                db.Ligneventes.AddOrUpdate(lignevente);
                db.SaveChanges();
            }
            (System.Windows.Forms.Application.OpenForms["Shop"] as Shop).LoadPanne();
        }

        private void imageProduit_DoubleClick(object sender, MouseEventArgs e)
        {
           /* using (ContextBase db = new ContextBase())
            {
                lignevente = db.Ligneventes.Where(l => l.IDProduit == produit.IDProduit && l.IDVente == vente.IDVente).FirstOrDefault();
                if (lignevente == null)
                    EffectVente(new Lignevente(), false);
                else
                    EffectVente(lignevente, true);
            }*/
        }
    }
}
