
namespace View
{
    partial class SupprissionDonnee
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.clientsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.categoriesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.ventesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.produitbtn = new Guna.UI2.WinForms.Guna2Button();
            this.ligneventesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.recuFacturesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.tousbtn = new Guna.UI2.WinForms.Guna2Button();
            this.container = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.container, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.54824F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.87595F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.728943F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1085, 653);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Controls.Add(this.tousbtn, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.recuFacturesbtn, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.ligneventesbtn, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.produitbtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.ventesbtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.categoriesbtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.clientsbtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1079, 88);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // clientsbtn
            // 
            this.clientsbtn.BorderRadius = 12;
            this.clientsbtn.CheckedState.Parent = this.clientsbtn;
            this.clientsbtn.CustomImages.Parent = this.clientsbtn;
            this.clientsbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clientsbtn.ForeColor = System.Drawing.Color.White;
            this.clientsbtn.HoverState.Parent = this.clientsbtn;
            this.clientsbtn.Location = new System.Drawing.Point(10, 10);
            this.clientsbtn.Margin = new System.Windows.Forms.Padding(10);
            this.clientsbtn.Name = "clientsbtn";
            this.clientsbtn.ShadowDecoration.Parent = this.clientsbtn;
            this.clientsbtn.Size = new System.Drawing.Size(134, 68);
            this.clientsbtn.TabIndex = 0;
            this.clientsbtn.Text = "Vider Clients";
            this.clientsbtn.Click += new System.EventHandler(this.clientsbtn_Click);
            this.clientsbtn.MouseHover += new System.EventHandler(this.clientsbtn_MouseHover);
            // 
            // categoriesbtn
            // 
            this.categoriesbtn.BorderRadius = 12;
            this.categoriesbtn.CheckedState.Parent = this.categoriesbtn;
            this.categoriesbtn.CustomImages.Parent = this.categoriesbtn;
            this.categoriesbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoriesbtn.ForeColor = System.Drawing.Color.White;
            this.categoriesbtn.HoverState.Parent = this.categoriesbtn;
            this.categoriesbtn.Location = new System.Drawing.Point(164, 10);
            this.categoriesbtn.Margin = new System.Windows.Forms.Padding(10);
            this.categoriesbtn.Name = "categoriesbtn";
            this.categoriesbtn.ShadowDecoration.Parent = this.categoriesbtn;
            this.categoriesbtn.Size = new System.Drawing.Size(134, 68);
            this.categoriesbtn.TabIndex = 1;
            this.categoriesbtn.Text = "Vider Categories";
            this.categoriesbtn.Click += new System.EventHandler(this.categoriesbtn_Click);
            this.categoriesbtn.MouseHover += new System.EventHandler(this.categoriesbtn_MouseHover);
            // 
            // ventesbtn
            // 
            this.ventesbtn.BorderRadius = 12;
            this.ventesbtn.CheckedState.Parent = this.ventesbtn;
            this.ventesbtn.CustomImages.Parent = this.ventesbtn;
            this.ventesbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventesbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ventesbtn.ForeColor = System.Drawing.Color.White;
            this.ventesbtn.HoverState.Parent = this.ventesbtn;
            this.ventesbtn.Location = new System.Drawing.Point(318, 10);
            this.ventesbtn.Margin = new System.Windows.Forms.Padding(10);
            this.ventesbtn.Name = "ventesbtn";
            this.ventesbtn.ShadowDecoration.Parent = this.ventesbtn;
            this.ventesbtn.Size = new System.Drawing.Size(134, 68);
            this.ventesbtn.TabIndex = 2;
            this.ventesbtn.Text = "Vider Ventes";
            this.ventesbtn.Click += new System.EventHandler(this.ventesbtn_Click);
            this.ventesbtn.MouseHover += new System.EventHandler(this.ventesbtn_MouseHover);
            // 
            // produitbtn
            // 
            this.produitbtn.BorderRadius = 12;
            this.produitbtn.CheckedState.Parent = this.produitbtn;
            this.produitbtn.CustomImages.Parent = this.produitbtn;
            this.produitbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produitbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.produitbtn.ForeColor = System.Drawing.Color.White;
            this.produitbtn.HoverState.Parent = this.produitbtn;
            this.produitbtn.Location = new System.Drawing.Point(472, 10);
            this.produitbtn.Margin = new System.Windows.Forms.Padding(10);
            this.produitbtn.Name = "produitbtn";
            this.produitbtn.ShadowDecoration.Parent = this.produitbtn;
            this.produitbtn.Size = new System.Drawing.Size(134, 68);
            this.produitbtn.TabIndex = 3;
            this.produitbtn.Text = "Vider Produits";
            this.produitbtn.Click += new System.EventHandler(this.produitbtn_Click);
            this.produitbtn.MouseHover += new System.EventHandler(this.produitbtn_MouseHover);
            // 
            // ligneventesbtn
            // 
            this.ligneventesbtn.BorderRadius = 12;
            this.ligneventesbtn.CheckedState.Parent = this.ligneventesbtn;
            this.ligneventesbtn.CustomImages.Parent = this.ligneventesbtn;
            this.ligneventesbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ligneventesbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ligneventesbtn.ForeColor = System.Drawing.Color.White;
            this.ligneventesbtn.HoverState.Parent = this.ligneventesbtn;
            this.ligneventesbtn.Location = new System.Drawing.Point(626, 10);
            this.ligneventesbtn.Margin = new System.Windows.Forms.Padding(10);
            this.ligneventesbtn.Name = "ligneventesbtn";
            this.ligneventesbtn.ShadowDecoration.Parent = this.ligneventesbtn;
            this.ligneventesbtn.Size = new System.Drawing.Size(134, 68);
            this.ligneventesbtn.TabIndex = 4;
            this.ligneventesbtn.Text = "Vider Ligneventes";
            this.ligneventesbtn.Click += new System.EventHandler(this.ligneventesbtn_Click);
            this.ligneventesbtn.MouseHover += new System.EventHandler(this.ligneventesbtn_MouseHover);
            // 
            // recuFacturesbtn
            // 
            this.recuFacturesbtn.BorderRadius = 12;
            this.recuFacturesbtn.CheckedState.Parent = this.recuFacturesbtn;
            this.recuFacturesbtn.CustomImages.Parent = this.recuFacturesbtn;
            this.recuFacturesbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recuFacturesbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.recuFacturesbtn.ForeColor = System.Drawing.Color.White;
            this.recuFacturesbtn.HoverState.Parent = this.recuFacturesbtn;
            this.recuFacturesbtn.Location = new System.Drawing.Point(780, 10);
            this.recuFacturesbtn.Margin = new System.Windows.Forms.Padding(10);
            this.recuFacturesbtn.Name = "recuFacturesbtn";
            this.recuFacturesbtn.ShadowDecoration.Parent = this.recuFacturesbtn;
            this.recuFacturesbtn.Size = new System.Drawing.Size(134, 68);
            this.recuFacturesbtn.TabIndex = 5;
            this.recuFacturesbtn.Text = "Vider RecuFactures";
            this.recuFacturesbtn.Click += new System.EventHandler(this.recuFacturesbtn_Click);
            this.recuFacturesbtn.MouseHover += new System.EventHandler(this.recuFacturesbtn_MouseHover);
            // 
            // tousbtn
            // 
            this.tousbtn.BorderRadius = 12;
            this.tousbtn.CheckedState.Parent = this.tousbtn;
            this.tousbtn.CustomImages.Parent = this.tousbtn;
            this.tousbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tousbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tousbtn.ForeColor = System.Drawing.Color.White;
            this.tousbtn.HoverState.Parent = this.tousbtn;
            this.tousbtn.Location = new System.Drawing.Point(934, 10);
            this.tousbtn.Margin = new System.Windows.Forms.Padding(10);
            this.tousbtn.Name = "tousbtn";
            this.tousbtn.ShadowDecoration.Parent = this.tousbtn;
            this.tousbtn.Size = new System.Drawing.Size(135, 68);
            this.tousbtn.TabIndex = 6;
            this.tousbtn.Text = "Vider Tous";
            this.tousbtn.Click += new System.EventHandler(this.tousbtn_Click);
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(3, 97);
            this.container.Name = "container";
            this.container.ShadowDecoration.Parent = this.container;
            this.container.Size = new System.Drawing.Size(1079, 495);
            this.container.TabIndex = 1;
            // 
            // SupprissionDonnee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupprissionDonnee";
            this.Text = "SupprissionDonnee";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button tousbtn;
        private Guna.UI2.WinForms.Guna2Button recuFacturesbtn;
        private Guna.UI2.WinForms.Guna2Button ligneventesbtn;
        private Guna.UI2.WinForms.Guna2Button produitbtn;
        private Guna.UI2.WinForms.Guna2Button ventesbtn;
        private Guna.UI2.WinForms.Guna2Button categoriesbtn;
        private Guna.UI2.WinForms.Guna2Button clientsbtn;
        private Guna.UI2.WinForms.Guna2Panel container;
    }
}