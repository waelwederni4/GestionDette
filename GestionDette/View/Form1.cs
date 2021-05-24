using Controleur;
using Model;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                if (pseudo.Text.Equals("wael") && password.Text.Equals("wael"))
                {
                    using (ContextBase db = new ContextBase())
                    {
                        Magasin magasin = db.Magasin.Where(m => m.IDMagasin == 1).FirstOrDefault();
                        if (magasin != null)
                        {
                            if (IsFormOpen(typeof(Dashbord)) != null)
                            {
                                IsFormOpen(typeof(Dashbord)).Close();
                            }
                            Dashbord p = new Dashbord();
                            p.Show(); 
                        }
                        else
                        {
                            if (IsFormOpen(typeof(MagazinFirst)) != null)
                            {
                                IsFormOpen(typeof(MagazinFirst)).Close();
                            }
                            MagazinFirst p = new MagazinFirst();
                            p.Show();
                        }
                        this.Hide();
                    }
                    
                }
                else
                {
                    MsgBoxForm msgBox = new MsgBoxForm("Pseudo ou Mot de pass incorrect");
                    msgBox.ShowDialog();
                    guna2CircleProgressBar1.Value = 0;
                    label2.Text = ""+0;
                    LoginView.Visible = true;
                    progressView.Visible = false;
                }
               

            }
            else
            {
                guna2CircleProgressBar1.Value += 5;
                label2.Text = (Convert.ToInt32(label2.Text) + 5).ToString();
            }
        }
        public Form IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return form;
            return null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToParent();
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pseudo.Text)|| string.IsNullOrEmpty(pseudo.Text))
            {
                MsgBoxForm msgBox = new MsgBoxForm("pseudo champ requis");
                msgBox.ShowDialog();
            }
                if (string.IsNullOrWhiteSpace(password.Text) || string.IsNullOrEmpty(password.Text)) { 
                MsgBoxForm msgBox = new MsgBoxForm("password champ requis");
                msgBox.ShowDialog();
                }

            if (!string.IsNullOrWhiteSpace(pseudo.Text) && !string.IsNullOrEmpty(pseudo.Text)&& !string.IsNullOrWhiteSpace(password.Text) && !string.IsNullOrEmpty(password.Text))
            {
                LoginView.Visible = false;
                progressView.Visible = true;
                timer1.Start();
            }
        }
    }
}
