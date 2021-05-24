
namespace View
{
    partial class Historique
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
            this.recuFacturesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.ligneventesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.produitbtn = new Guna.UI2.WinForms.Guna2Button();
            this.ventesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.categoriesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.clientsbtn = new Guna.UI2.WinForms.Guna2Button();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.29054F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.351351F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(835, 592);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(829, 79);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.recuFacturesbtn.Location = new System.Drawing.Point(700, 10);
            this.recuFacturesbtn.Margin = new System.Windows.Forms.Padding(10);
            this.recuFacturesbtn.Name = "recuFacturesbtn";
            this.recuFacturesbtn.ShadowDecoration.Parent = this.recuFacturesbtn;
            this.recuFacturesbtn.Size = new System.Drawing.Size(119, 59);
            this.recuFacturesbtn.TabIndex = 5;
            this.recuFacturesbtn.Text = "RecuFactures";
            this.recuFacturesbtn.Click += new System.EventHandler(this.recuFacturesbtn_Click);
            this.recuFacturesbtn.MouseHover += new System.EventHandler(this.recuFacturesbtn_MouseHover);
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
            this.ligneventesbtn.Location = new System.Drawing.Point(562, 10);
            this.ligneventesbtn.Margin = new System.Windows.Forms.Padding(10);
            this.ligneventesbtn.Name = "ligneventesbtn";
            this.ligneventesbtn.ShadowDecoration.Parent = this.ligneventesbtn;
            this.ligneventesbtn.Size = new System.Drawing.Size(118, 59);
            this.ligneventesbtn.TabIndex = 4;
            this.ligneventesbtn.Text = "Ligneventes";
            this.ligneventesbtn.Click += new System.EventHandler(this.ligneventesbtn_Click);
            this.ligneventesbtn.MouseHover += new System.EventHandler(this.ligneventesbtn_MouseHover);
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
            this.produitbtn.Location = new System.Drawing.Point(424, 10);
            this.produitbtn.Margin = new System.Windows.Forms.Padding(10);
            this.produitbtn.Name = "produitbtn";
            this.produitbtn.ShadowDecoration.Parent = this.produitbtn;
            this.produitbtn.Size = new System.Drawing.Size(118, 59);
            this.produitbtn.TabIndex = 3;
            this.produitbtn.Text = "Produits";
            this.produitbtn.Click += new System.EventHandler(this.produitbtn_Click);
            this.produitbtn.MouseHover += new System.EventHandler(this.produitbtn_MouseHover);
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
            this.ventesbtn.Location = new System.Drawing.Point(286, 10);
            this.ventesbtn.Margin = new System.Windows.Forms.Padding(10);
            this.ventesbtn.Name = "ventesbtn";
            this.ventesbtn.ShadowDecoration.Parent = this.ventesbtn;
            this.ventesbtn.Size = new System.Drawing.Size(118, 59);
            this.ventesbtn.TabIndex = 2;
            this.ventesbtn.Text = "Ventes";
            this.ventesbtn.Click += new System.EventHandler(this.ventesbtn_Click);
            this.ventesbtn.MouseHover += new System.EventHandler(this.ventesbtn_MouseHover);
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
            this.categoriesbtn.Location = new System.Drawing.Point(148, 10);
            this.categoriesbtn.Margin = new System.Windows.Forms.Padding(10);
            this.categoriesbtn.Name = "categoriesbtn";
            this.categoriesbtn.ShadowDecoration.Parent = this.categoriesbtn;
            this.categoriesbtn.Size = new System.Drawing.Size(118, 59);
            this.categoriesbtn.TabIndex = 1;
            this.categoriesbtn.Text = "Categories";
            this.categoriesbtn.Click += new System.EventHandler(this.categoriesbtn_Click);
            this.categoriesbtn.MouseHover += new System.EventHandler(this.categoriesbtn_MouseHover);
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
            this.clientsbtn.Size = new System.Drawing.Size(118, 59);
            this.clientsbtn.TabIndex = 0;
            this.clientsbtn.Text = "Clients";
            this.clientsbtn.Click += new System.EventHandler(this.clientsbtn_Click);
            this.clientsbtn.MouseHover += new System.EventHandler(this.clientsbtn_MouseHover);
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(3, 88);
            this.container.Name = "container";
            this.container.ShadowDecoration.Parent = this.container;
            this.container.Size = new System.Drawing.Size(829, 492);
            this.container.TabIndex = 1;
            // 
            // Historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historique";
            this.Text = "Historique";
            this.Load += new System.EventHandler(this.Historique_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button recuFacturesbtn;
        private Guna.UI2.WinForms.Guna2Button ligneventesbtn;
        private Guna.UI2.WinForms.Guna2Button produitbtn;
        private Guna.UI2.WinForms.Guna2Button ventesbtn;
        private Guna.UI2.WinForms.Guna2Button categoriesbtn;
        private Guna.UI2.WinForms.Guna2Button clientsbtn;
        private Guna.UI2.WinForms.Guna2Panel container;
    }
}