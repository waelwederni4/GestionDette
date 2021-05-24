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
    public partial class MsgBoxForm : Form
    {

    int count;
        String msg;
        public MsgBoxForm(String msg)
        {
            this.msg = msg;
            InitializeComponent();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count -= 20;
            if (count == 0)
            {
                this.Close();
            }
        }

        private void MsgBox_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            CenterToParent();
            guna2ShadowForm1.SetShadowForm(this);
            count = 200;
            label1.Text = msg;
           // Width = label1.Width + 20;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
