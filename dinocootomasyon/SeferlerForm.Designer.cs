namespace dinocootomasyon
{
    partial class SeferlerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.seferlerpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.seferlerdatagrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.seferlerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seferlerdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // seferlerpanel
            // 
            this.seferlerpanel.BackColor = System.Drawing.Color.Transparent;
            this.seferlerpanel.BackgroundImage = global::dinocootomasyon.Properties.Resources.seferlerpanel;
            this.seferlerpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seferlerpanel.Controls.Add(this.seferlerdatagrid);
            this.seferlerpanel.Location = new System.Drawing.Point(-26, -34);
            this.seferlerpanel.Name = "seferlerpanel";
            this.seferlerpanel.ShadowDecoration.Parent = this.seferlerpanel;
            this.seferlerpanel.Size = new System.Drawing.Size(893, 570);
            this.seferlerpanel.TabIndex = 0;
            // 
            // seferlerdatagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.seferlerdatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.seferlerdatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.seferlerdatagrid.BackgroundColor = System.Drawing.Color.White;
            this.seferlerdatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seferlerdatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.seferlerdatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.seferlerdatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.seferlerdatagrid.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.seferlerdatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.seferlerdatagrid.EnableHeadersVisualStyles = false;
            this.seferlerdatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.seferlerdatagrid.Location = new System.Drawing.Point(61, 60);
            this.seferlerdatagrid.Name = "seferlerdatagrid";
            this.seferlerdatagrid.RowHeadersVisible = false;
            this.seferlerdatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.seferlerdatagrid.Size = new System.Drawing.Size(763, 431);
            this.seferlerdatagrid.TabIndex = 26;
            this.seferlerdatagrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.seferlerdatagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.seferlerdatagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.seferlerdatagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.seferlerdatagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.seferlerdatagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.seferlerdatagrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.seferlerdatagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.seferlerdatagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.seferlerdatagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.seferlerdatagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.seferlerdatagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.seferlerdatagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.seferlerdatagrid.ThemeStyle.HeaderStyle.Height = 4;
            this.seferlerdatagrid.ThemeStyle.ReadOnly = false;
            this.seferlerdatagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.seferlerdatagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.seferlerdatagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.seferlerdatagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.seferlerdatagrid.ThemeStyle.RowsStyle.Height = 22;
            this.seferlerdatagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.seferlerdatagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // SeferlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 508);
            this.Controls.Add(this.seferlerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeferlerForm";
            this.Text = "seferlerform";
            this.Load += new System.EventHandler(this.SeferlerForm_Load);
            this.seferlerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seferlerdatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel seferlerpanel;
        public Guna.UI2.WinForms.Guna2DataGridView seferlerdatagrid;
    }
}