
namespace View
{
    partial class ProduitList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DataGridViewProduits = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.nomProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QteProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // DataGridViewProduits
            // 
            this.DataGridViewProduits.AllowUserToAddRows = false;
            this.DataGridViewProduits.AllowUserToDeleteRows = false;
            this.DataGridViewProduits.AllowUserToResizeColumns = false;
            this.DataGridViewProduits.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridViewProduits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewProduits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewProduits.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewProduits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewProduits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewProduits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewProduits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewProduits.ColumnHeadersHeight = 52;
            this.DataGridViewProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.nomProduit,
            this.prixProduit,
            this.QteProduit,
            this.Total});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewProduits.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewProduits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewProduits.EnableHeadersVisualStyles = false;
            this.DataGridViewProduits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewProduits.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewProduits.Name = "DataGridViewProduits";
            this.DataGridViewProduits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridViewProduits.RowHeadersVisible = false;
            this.DataGridViewProduits.RowHeadersWidth = 24;
            this.DataGridViewProduits.RowTemplate.Height = 100;
            this.DataGridViewProduits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewProduits.Size = new System.Drawing.Size(800, 450);
            this.DataGridViewProduits.TabIndex = 9;
            this.DataGridViewProduits.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewProduits.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewProduits.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewProduits.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewProduits.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewProduits.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewProduits.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewProduits.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewProduits.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DataGridViewProduits.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewProduits.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewProduits.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewProduits.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewProduits.ThemeStyle.HeaderStyle.Height = 52;
            this.DataGridViewProduits.ThemeStyle.ReadOnly = false;
            this.DataGridViewProduits.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewProduits.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewProduits.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewProduits.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewProduits.ThemeStyle.RowsStyle.Height = 100;
            this.DataGridViewProduits.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewProduits.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Image.DataPropertyName = "Image";
            this.Image.Frozen = true;
            this.Image.HeaderText = "";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Image.MinimumWidth = 3;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Image.Width = 80;
            // 
            // nomProduit
            // 
            this.nomProduit.DataPropertyName = "nomProduit";
            this.nomProduit.HeaderText = "Nom";
            this.nomProduit.MinimumWidth = 3;
            this.nomProduit.Name = "nomProduit";
            this.nomProduit.ReadOnly = true;
            this.nomProduit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // prixProduit
            // 
            this.prixProduit.DataPropertyName = "prixProduit";
            this.prixProduit.HeaderText = "Prix";
            this.prixProduit.MinimumWidth = 3;
            this.prixProduit.Name = "prixProduit";
            this.prixProduit.ReadOnly = true;
            this.prixProduit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // QteProduit
            // 
            this.QteProduit.DataPropertyName = "QteProduit";
            this.QteProduit.HeaderText = "Qte";
            this.QteProduit.MinimumWidth = 3;
            this.QteProduit.Name = "QteProduit";
            this.QteProduit.ReadOnly = true;
            this.QteProduit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "prixTotal";
            this.Total.HeaderText = "prixTotal";
            this.Total.MinimumWidth = 3;
            this.Total.Name = "Total";
            // 
            // ProduitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewProduits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProduitList";
            this.Text = "ProduitList";
            this.Load += new System.EventHandler(this.ProduitList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewProduits;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn QteProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}