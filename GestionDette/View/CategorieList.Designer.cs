
namespace View
{
    partial class CategorieList
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
            this.DataGridViewVente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IDCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVente)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // DataGridViewVente
            // 
            this.DataGridViewVente.AllowUserToAddRows = false;
            this.DataGridViewVente.AllowUserToDeleteRows = false;
            this.DataGridViewVente.AllowUserToResizeColumns = false;
            this.DataGridViewVente.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridViewVente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewVente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewVente.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewVente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewVente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewVente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewVente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewVente.ColumnHeadersHeight = 52;
            this.DataGridViewVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewVente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCategorie,
            this.nomCategorie});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewVente.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewVente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewVente.EnableHeadersVisualStyles = false;
            this.DataGridViewVente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewVente.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewVente.Name = "DataGridViewVente";
            this.DataGridViewVente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridViewVente.RowHeadersVisible = false;
            this.DataGridViewVente.RowHeadersWidth = 24;
            this.DataGridViewVente.RowTemplate.Height = 100;
            this.DataGridViewVente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewVente.Size = new System.Drawing.Size(800, 450);
            this.DataGridViewVente.TabIndex = 9;
            this.DataGridViewVente.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewVente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewVente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewVente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewVente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewVente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewVente.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewVente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewVente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DataGridViewVente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewVente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewVente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewVente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewVente.ThemeStyle.HeaderStyle.Height = 52;
            this.DataGridViewVente.ThemeStyle.ReadOnly = false;
            this.DataGridViewVente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewVente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewVente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewVente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewVente.ThemeStyle.RowsStyle.Height = 100;
            this.DataGridViewVente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewVente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // IDCategorie
            // 
            this.IDCategorie.DataPropertyName = "IDCategorie";
            this.IDCategorie.HeaderText = "#id";
            this.IDCategorie.MinimumWidth = 3;
            this.IDCategorie.Name = "IDCategorie";
            this.IDCategorie.ReadOnly = true;
            this.IDCategorie.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nomCategorie
            // 
            this.nomCategorie.DataPropertyName = "nomCategorie";
            this.nomCategorie.HeaderText = "Nom";
            this.nomCategorie.MinimumWidth = 3;
            this.nomCategorie.Name = "nomCategorie";
            this.nomCategorie.ReadOnly = true;
            this.nomCategorie.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CategorieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewVente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategorieList";
            this.Text = "CategorieList";
            this.Load += new System.EventHandler(this.CategorieList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCategorie;
    }
}