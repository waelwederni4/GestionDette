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

namespace View
{
    public partial class ProduitVList : Form
    {
        List<Lignevente> ligneventes;
        Vente vente;
        RecuFacture recuFacture;
        public ProduitVList(Vente vente)
        {
            this.vente=vente;
            InitializeComponent();
        }

        private void ProduitVList_Load(object sender, EventArgs e)
        {
            DataGridViewProduits.AutoGenerateColumns = false;
            DataGridViewProduits.DataSource = null;
            this.DataGridViewProduits.Rows.Clear();
            using (ContextBase db = new ContextBase())
            {
                if (db.Ligneventes.Where(l => l.IDVente == vente.IDVente).ToList() != null)
                {
                    ligneventes = db.Ligneventes.Where(l => l.IDVente == vente.IDVente).ToList();
                    recuFacture = db.RecuFactures.Where(rf => rf.IDVente == vente.IDVente).FirstOrDefault();
                    
                    foreach (Lignevente lignevente in ligneventes)
                    {
                        Bitmap image;
                        if (lignevente.Produit.Image == null)
                            image = Properties.Resources.No_Image_Available;
                        else
                            image = ByteToImage(lignevente.Produit.Image);
                        DataGridViewProduits.Rows.Add(image, lignevente.Produit.nomProduit, lignevente.Produit.prixProduit, lignevente.QteProduit, lignevente.prixTotal);
                    }
                    tvTotal.Text = string.Format("{0} TND", recuFacture.Totale);
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
    }
}
