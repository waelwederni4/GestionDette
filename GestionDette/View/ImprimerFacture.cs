using Controleur;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ImprimerFacture : Form
    {
        RecuFacture recuFacture;
        List<Lignevente> ligneventes;
        List<Vente> ventes;
        List<ProduitsFacture> produitsFactures;
        private int m_currentPageIndex;
        private IList<Stream> m_streams;
        Vente vente;
        Model.Client client;
        bool IsCash;
        double cash;
        double reste=0.0;
        public ImprimerFacture(Vente vente)
        {
            this.vente = vente;
            IsCash = false;
            InitializeComponent();
        }
        public ImprimerFacture(Model.Client client,double cash)
        {
            this.cash = cash;
            this.client = client;
            IsCash = true;
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImprimerFacture_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            CenterToParent();
            guna2ShadowForm1.SetShadowForm(this);
            produitsFactures = new List<ProduitsFacture>();
            List<ReportParameter> para=new List<ReportParameter>();
            reportViewer1.Reset();
            if (IsCash)
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "View.Report1.rdlc";
                reportViewer1.LocalReport.ReportPath = @"../../../Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                double total = 0.0;
                using (ContextBase db = new ContextBase())
                {
                    ventes = db.Ventes.Where(rf => rf.IDClient == client.IDClient).ToList();
                    foreach (Vente v in ventes)
                    {
                        recuFacture = db.RecuFactures.Where(rf => rf.IDVente == v.IDVente).FirstOrDefault();
                        if (recuFacture != null)
                        {
                            total += recuFacture.Totale ?? 0.0;
                        }
                        ligneventes = db.Ligneventes.Where(l => l.IDVente == v.IDVente).ToList();
                        foreach (Lignevente lignevente in ligneventes)
                        {
                            ProduitsFacture produitsFacture = new ProduitsFacture();
                            Produit produit;
                            produit = db.Produits.Where(p => p.IDProduit == lignevente.IDProduit).FirstOrDefault();
                            produitsFacture.nomProduit = produit.nomProduit;
                            produitsFacture.prixProduit = produit.prixProduit;
                            produitsFacture.QteProduit = lignevente.QteProduit;
                            produitsFacture.prixTotal = lignevente.prixTotal;
                            produitsFacture.dateVente = v.dateVente;
                            produitsFactures.Add(produitsFacture);
                        }
                        
                    }
                }
                reste = total - cash;
                para.Add(new ReportParameter("Total", string.Format("{0} TND", total)));
                para.Add(new ReportParameter("dateFacture", DateTime.Now.ToString()));
                para.Add(new ReportParameter("Cash", string.Format("{0} TND", cash)));
                para.Add(new ReportParameter("Reste", string.Format("{0} TND", reste)));
            }
            else
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "View.FactureVente.rdlc";
                reportViewer1.LocalReport.ReportPath = @"../../../FactureVente.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                using (ContextBase db = new ContextBase())
                {
                    recuFacture = db.RecuFactures.Where(rf => rf.IDVente == vente.IDVente).FirstOrDefault();
                    ligneventes = db.Ligneventes.Where(l => l.IDVente == vente.IDVente).ToList();
                }
                foreach (Lignevente lignevente in ligneventes)
                {
                    ProduitsFacture produitsFacture = new ProduitsFacture();
                    Produit produit;
                    using (ContextBase db = new ContextBase())
                    {
                        produit = db.Produits.Where(p => p.IDProduit == lignevente.IDProduit).FirstOrDefault();
                    }
                    produitsFacture.nomProduit = produit.nomProduit;
                    produitsFacture.prixProduit = produit.prixProduit;
                    produitsFacture.QteProduit = lignevente.QteProduit;
                    produitsFacture.prixTotal = lignevente.prixTotal;
                    produitsFactures.Add(produitsFacture);
                }
                using (ContextBase db = new ContextBase())
                {
                    client = db.Clients.Where(p => p.IDClient == vente.IDClient).FirstOrDefault();
                }
                para.Add(new ReportParameter("Total", string.Format("{0} TND", recuFacture.Totale)));
                para.Add(new ReportParameter("dateVente", vente.dateVente.ToString()));
            }
            para.Add(new ReportParameter("nomClient", client.nomClient));
            para.Add(new ReportParameter("prenomClient", client.prenomClient));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", produitsFactures));
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Export(reportViewer1.LocalReport);
            Print();
            // PrintToPrinter();
        }
        private Stream CreateStream(string name,
      string fileNameExtension, Encoding encoding,
      string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }
        private void Export(LocalReport report)
        {
            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>8.5in</PageWidth>
                <PageHeight>11in</PageHeight>
                <MarginTop>0.25in</MarginTop>
                <MarginLeft>0.25in</MarginLeft>
                <MarginRight>0.25in</MarginRight>
                <MarginBottom>0.25in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }
        private void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
            Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }
       /* private  void PrintToPrinter(LocalReport report)
        {
            PageSettings pageSettings = new PageSettings();
            pageSettings.PaperSize = report.GetDefaultPageSettings().PaperSize;
            pageSettings.Landscape = report.GetDefaultPageSettings().IsLandscape;
            pageSettings.Margins = report.GetDefaultPageSettings().Margins;
            Print(report, pageSettings);
        }

        private void Print(LocalReport report, PageSettings pageSettings)
        {
            string deviceInfo =
                $@"<DeviceInfo>
                    <OutputFormat>EMF</OutputFormat>
                    <PageWidth>{pageSettings.PaperSize.Width * 100}in</PageWidth>
                    <PageHeight>{pageSettings.PaperSize.Height * 100}in</PageHeight>
                    <MarginTop>{pageSettings.Margins.Top * 100}in</MarginTop>
                    <MarginLeft>{pageSettings.Margins.Left * 100}in</MarginLeft>
                    <MarginRight>{pageSettings.Margins.Right * 100}in</MarginRight>
                    <MarginBottom>{pageSettings.Margins.Bottom * 100}in</MarginBottom>
                </DeviceInfo>";
            Warning[] warnings;
            var streams = new List<Stream>();
            var pageIndex = 0;
            report.Render("Image", deviceInfo,
                (name, fileNameExtension, encoding, mimeType, willSeek) =>
                {
                    MemoryStream stream = new MemoryStream();
                    streams.Add(stream);
                    return stream;
                }, out warnings);
            foreach (Stream stream in streams)
                stream.Position = 0;
            if (streams == null || streams.Count == 0)
                throw new Exception("No stream to print.");
            using (PrintDocument printDocument = new PrintDocument())
            {
                printDocument.DefaultPageSettings = pageSettings;
                if (!printDocument.PrinterSettings.IsValid)
                    throw new Exception("Can't find the default printer.");
                else
                {
                    printDocument.PrintPage += (sender, e) =>
                    {
                        Metafile pageImage = new Metafile(streams[pageIndex]);
                        Rectangle adjustedRect = new Rectangle(e.PageBounds.Left - (int)e.PageSettings.HardMarginX, e.PageBounds.Top - (int)e.PageSettings.HardMarginY, e.PageBounds.Width, e.PageBounds.Height);
                        e.Graphics.FillRectangle(Brushes.White, adjustedRect);
                        e.Graphics.DrawImage(pageImage, adjustedRect);
                        pageIndex++;
                        e.HasMorePages = (pageIndex < streams.Count);
                        e.Graphics.DrawRectangle(Pens.Red, adjustedRect);
                    };
                    printDocument.EndPrint += (Sender, e) =>
                    {
                        if (streams != null)
                        {
                            foreach (Stream stream in streams)
                                stream.Close();
                            streams = null;
                        }
                    };
                    printDocument.Print();
                }
            }
        }*/
    
}
}
