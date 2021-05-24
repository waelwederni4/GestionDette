
namespace View
{
    partial class GestionClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.adress = new Guna.UI2.WinForms.Guna2TextBox();
            this.numTel = new Guna.UI2.WinForms.Guna2TextBox();
            this.prenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dette = new System.Windows.Forms.Label();
            this.detteTv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Button1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(0, 380);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(800, 70);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Submit";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(170)))), ((int)(((byte)(226)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(754, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // adress
            // 
            this.adress.Animated = true;
            this.adress.BorderRadius = 8;
            this.adress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adress.DefaultText = "";
            this.adress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adress.DisabledState.Parent = this.adress;
            this.adress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.adress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adress.FocusedState.Parent = this.adress;
            this.adress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adress.HoverState.Parent = this.adress;
            this.adress.IconLeft = global::View.Properties.Resources.home;
            this.adress.Location = new System.Drawing.Point(165, 328);
            this.adress.Name = "adress";
            this.adress.PasswordChar = '\0';
            this.adress.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.adress.PlaceholderText = "Adresse Client\r\n";
            this.adress.SelectedText = "";
            this.adress.ShadowDecoration.Parent = this.adress;
            this.adress.Size = new System.Drawing.Size(459, 36);
            this.adress.TabIndex = 6;
            // 
            // numTel
            // 
            this.numTel.Animated = true;
            this.numTel.BorderRadius = 8;
            this.numTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numTel.DefaultText = "";
            this.numTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numTel.DisabledState.Parent = this.numTel;
            this.numTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numTel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.numTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numTel.FocusedState.Parent = this.numTel;
            this.numTel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numTel.HoverState.Parent = this.numTel;
            this.numTel.IconLeft = global::View.Properties.Resources.phone;
            this.numTel.Location = new System.Drawing.Point(165, 275);
            this.numTel.Name = "numTel";
            this.numTel.PasswordChar = '\0';
            this.numTel.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.numTel.PlaceholderText = "Numero du télephone";
            this.numTel.SelectedText = "";
            this.numTel.ShadowDecoration.Parent = this.numTel;
            this.numTel.Size = new System.Drawing.Size(459, 36);
            this.numTel.TabIndex = 5;
            // 
            // prenom
            // 
            this.prenom.Animated = true;
            this.prenom.BorderRadius = 8;
            this.prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prenom.DefaultText = "";
            this.prenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prenom.DisabledState.Parent = this.prenom;
            this.prenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prenom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.prenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prenom.FocusedState.Parent = this.prenom;
            this.prenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prenom.HoverState.Parent = this.prenom;
            this.prenom.IconLeft = global::View.Properties.Resources.user1;
            this.prenom.Location = new System.Drawing.Point(165, 222);
            this.prenom.Name = "prenom";
            this.prenom.PasswordChar = '\0';
            this.prenom.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.prenom.PlaceholderText = "Prenom Client";
            this.prenom.SelectedText = "";
            this.prenom.ShadowDecoration.Parent = this.prenom;
            this.prenom.Size = new System.Drawing.Size(459, 36);
            this.prenom.TabIndex = 4;
            // 
            // nom
            // 
            this.nom.Animated = true;
            this.nom.BorderRadius = 8;
            this.nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom.DefaultText = "";
            this.nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.DisabledState.Parent = this.nom;
            this.nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.FocusedState.Parent = this.nom;
            this.nom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.HoverState.Parent = this.nom;
            this.nom.IconLeft = global::View.Properties.Resources.user1;
            this.nom.Location = new System.Drawing.Point(165, 167);
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.nom.PlaceholderText = "Nom du Client";
            this.nom.SelectedText = "";
            this.nom.ShadowDecoration.Parent = this.nom;
            this.nom.Size = new System.Drawing.Size(459, 36);
            this.nom.TabIndex = 3;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox1.Image = global::View.Properties.Resources.topBg;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(800, 455);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // dette
            // 
            this.dette.AutoSize = true;
            this.dette.BackColor = System.Drawing.Color.White;
            this.dette.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dette.Location = new System.Drawing.Point(521, 130);
            this.dette.Name = "dette";
            this.dette.Size = new System.Drawing.Size(27, 34);
            this.dette.TabIndex = 7;
            this.dette.Text = "0";
            // 
            // detteTv
            // 
            this.detteTv.AutoSize = true;
            this.detteTv.BackColor = System.Drawing.Color.White;
            this.detteTv.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detteTv.Location = new System.Drawing.Point(425, 130);
            this.detteTv.Name = "detteTv";
            this.detteTv.Size = new System.Drawing.Size(95, 34);
            this.detteTv.TabIndex = 8;
            this.detteTv.Text = "Dette :";
            // 
            // GestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.detteTv);
            this.Controls.Add(this.dette);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.numTel);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionClient";
            this.Text = "GestionClient";
            this.Load += new System.EventHandler(this.GestionClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox numTel;
        private Guna.UI2.WinForms.Guna2TextBox nom;
        private Guna.UI2.WinForms.Guna2TextBox prenom;
        private Guna.UI2.WinForms.Guna2TextBox adress;
        private System.Windows.Forms.Label dette;
        private System.Windows.Forms.Label detteTv;
    }
}