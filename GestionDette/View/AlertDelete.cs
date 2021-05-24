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
    public partial class AlertDelete : Form
    {
        Model.Client client;
        string text;
        bool res = false;
        bool magasin = false;
        public AlertDelete(Model.Client clt)
        {
            res = false;
            this.client = clt;
            InitializeComponent();
        }
        public AlertDelete(string text)
        {
            res = false;
            this.text = text;
            InitializeComponent();
        }
        public AlertDelete(string text,bool res, bool magasin)
        {
            this.magasin = magasin;
            this.res = res;
            this.text = text;
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
                if (client != null)
                {
                    if (System.Windows.Forms.Application.OpenForms["Client"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["Client"] as Client).AddClient(client);
                    }
                }
                this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlertDelete_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            CenterToParent();
            guna2ShadowForm1.SetShadowForm(this);
            if (!string.IsNullOrEmpty(text)) label1.Text = text;
        }
    }
}
