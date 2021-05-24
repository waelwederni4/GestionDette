
namespace View
{
    partial class ProduitAchat
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageProduit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.nomProduit = new System.Windows.Forms.Label();
            this.prixproduit = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.qte = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduit)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qte)).BeginInit();
            this.SuspendLayout();
            // 
            // imageProduit
            // 
            this.imageProduit.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageProduit.Image = global::View.Properties.Resources.No_Image_Available;
            this.imageProduit.Location = new System.Drawing.Point(5, 5);
            this.imageProduit.Name = "imageProduit";
            this.imageProduit.ShadowDecoration.Parent = this.imageProduit;
            this.imageProduit.Size = new System.Drawing.Size(224, 203);
            this.imageProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageProduit.TabIndex = 0;
            this.imageProduit.TabStop = false;
            this.imageProduit.DoubleClick += new System.EventHandler(this.imageProduit_DoubleClick);
            this.imageProduit.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.imageProduit_DoubleClick);
            // 
            // nomProduit
            // 
            this.nomProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nomProduit.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomProduit.Location = new System.Drawing.Point(3, 0);
            this.nomProduit.Name = "nomProduit";
            this.nomProduit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nomProduit.Size = new System.Drawing.Size(218, 34);
            this.nomProduit.TabIndex = 1;
            this.nomProduit.Text = "يؤريس";
            this.nomProduit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prixproduit
            // 
            this.prixproduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prixproduit.Location = new System.Drawing.Point(3, 34);
            this.prixproduit.Name = "prixproduit";
            this.prixproduit.Size = new System.Drawing.Size(218, 34);
            this.prixproduit.TabIndex = 2;
            this.prixproduit.Text = "1500";
            this.prixproduit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.prixproduit, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nomProduit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.qte, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 211);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85715F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 120);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // qte
            // 
            this.qte.BackColor = System.Drawing.Color.Transparent;
            this.qte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qte.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.qte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.qte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.qte.DisabledState.Parent = this.qte;
            this.qte.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.qte.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.qte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qte.FocusedState.Parent = this.qte;
            this.qte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.qte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.qte.Location = new System.Drawing.Point(3, 71);
            this.qte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qte.Name = "qte";
            this.qte.ShadowDecoration.Parent = this.qte;
            this.qte.Size = new System.Drawing.Size(218, 46);
            this.qte.TabIndex = 3;
            this.qte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProduitAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.imageProduit);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProduitAchat";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(234, 336);
            this.Load += new System.EventHandler(this.ProduitAchat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageProduit)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox imageProduit;
        private System.Windows.Forms.Label nomProduit;
        private System.Windows.Forms.Label prixproduit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown qte;
    }
}
