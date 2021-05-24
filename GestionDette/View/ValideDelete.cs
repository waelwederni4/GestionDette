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
    public partial class ValideDelete : Form
    {
        string text;
        int index=-1;
        public ValideDelete(string text)
        {
            this.text = text;
            InitializeComponent();
        }
        public ValideDelete(string text, int index)
        {
            this.text = text;
            this.index = index;
            InitializeComponent();
        }

        private void ValideDelete_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            CenterToParent();
            guna2ShadowForm1.SetShadowForm(this);
            if (!string.IsNullOrEmpty(text)) label1.Text = text;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (password.Text.Equals("wael"))
            {
                if (index==-1)
                {
                    (System.Windows.Forms.Application.OpenForms["MagazinInfo"] as MagazinInfo).VideMagasin();
                }
                else
                {
                    (System.Windows.Forms.Application.OpenForms["SupprissionDonnee"] as SupprissionDonnee).Vider(index);
                }
                this.Close();
            }
            else
            {
                MsgBoxForm msgBox = new MsgBoxForm("Mot de pass incorrect");
                msgBox.ShowDialog();
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
