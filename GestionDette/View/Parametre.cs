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
    public partial class Parametre : Form
    {
        public Parametre()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(Info)) != null)
            {
                IsFormOpen(typeof(Info)).Close();
            }
            Getcontainer(new Info(), infoBtn);
        }

        private void MagazinBtn_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(MagazinInfo)) != null)
            {
                IsFormOpen(typeof(MagazinInfo)).Close();
            }
            Getcontainer(new MagazinInfo(), MagazinBtn);
        }

        private void histoBtn_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(Historique)) != null)
            {
                IsFormOpen(typeof(Historique)).Close();
            }
            Getcontainer(new Historique(), histoBtn);
        }

        private void suppBtn_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(SupprissionDonnee)) != null)
            {
                IsFormOpen(typeof(SupprissionDonnee)).Close();
            }
            Getcontainer(new SupprissionDonnee(), suppBtn);
        }
        public Form IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return form;
            return null;
        }
        private void Getcontainer(object _form, object sender)
        {
            
            ((Guna.UI2.WinForms.Guna2Button)sender).Checked = true;
            if (container.Controls.Count > 0) container.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            container.Controls.Add(fm);
            container.Tag = fm;
            fm.Show();

        }

        private void MagazinBtn_MouseHover(object sender, EventArgs e)
        {
            infoBtn.Checked = false;
            histoBtn.Checked = false;
            suppBtn.Checked = false;
        }

        private void histoBtn_MouseHover(object sender, EventArgs e)
        {
            infoBtn.Checked = false;
            suppBtn.Checked = false;
            MagazinBtn.Checked = false;
        }

        private void suppBtn_MouseHover(object sender, EventArgs e)
        {
            infoBtn.Checked = false;
            histoBtn.Checked = false;
            MagazinBtn.Checked = false;
        }

        private void infoBtn_MouseHover(object sender, EventArgs e)
        {
            suppBtn.Checked = false;
            histoBtn.Checked = false;
            MagazinBtn.Checked = false;
        }

        private void MagazinBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (MagazinBtn.Checked)
            {
                infoBtn.Checked = false;
                histoBtn.Checked = false;
                suppBtn.Checked = false;
            }
        }

        private void histoBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (histoBtn.Checked)
            {
                infoBtn.Checked = false;
                suppBtn.Checked = false;
                MagazinBtn.Checked = false;
            }
        }

        private void suppBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (suppBtn.Checked)
            {
                infoBtn.Checked = false;
                histoBtn.Checked = false;
                MagazinBtn.Checked = false;
            }
        }

        private void infoBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (infoBtn.Checked)
            {
                suppBtn.Checked = false;
                histoBtn.Checked = false;
                MagazinBtn.Checked = false;
            }
        }
    }
}
