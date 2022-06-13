namespace dinocootomasyon
{
    partial class BiletIptalForm
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
            this.arkapanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.biletiptalbtn = new Guna.UI2.WinForms.Guna2Button();
            this.iptaldatagrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ustpanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.arkapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iptaldatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // arkapanel
            // 
            this.arkapanel.Controls.Add(this.biletiptalbtn);
            this.arkapanel.Controls.Add(this.iptaldatagrid);
            this.arkapanel.Controls.Add(this.ustpanel);
            this.arkapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arkapanel.FillColor = System.Drawing.Color.DarkSlateGray;
            this.arkapanel.FillColor2 = System.Drawing.Color.Cyan;
            this.arkapanel.Location = new System.Drawing.Point(0, 0);
            this.arkapanel.Name = "arkapanel";
            this.arkapanel.ShadowDecoration.Parent = this.arkapanel;
            this.arkapanel.Size = new System.Drawing.Size(871, 471);
            this.arkapanel.TabIndex = 0;
            // 
            // biletiptalbtn
            // 
            this.biletiptalbtn.Animated = true;
            this.biletiptalbtn.AutoRoundedCorners = true;
            this.biletiptalbtn.BackColor = System.Drawing.Color.Transparent;
            this.biletiptalbtn.BackgroundImage = global::dinocootomasyon.Properties.Resources.Varlık_42;
            this.biletiptalbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.biletiptalbtn.BorderRadius = 23;
            this.biletiptalbtn.CheckedState.Parent = this.biletiptalbtn;
            this.biletiptalbtn.CustomImages.Parent = this.biletiptalbtn;
            this.biletiptalbtn.FillColor = System.Drawing.Color.Transparent;
            this.biletiptalbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.biletiptalbtn.ForeColor = System.Drawing.Color.Transparent;
            this.biletiptalbtn.HoverState.Parent = this.biletiptalbtn;
            this.biletiptalbtn.Location = new System.Drawing.Point(331, 410);
            this.biletiptalbtn.Name = "biletiptalbtn";
            this.biletiptalbtn.ShadowDecoration.Parent = this.biletiptalbtn;
            this.biletiptalbtn.Size = new System.Drawing.Size(198, 49);
            this.biletiptalbtn.TabIndex = 26;
            this.biletiptalbtn.Text = "sefereklebtn";
            this.biletiptalbtn.Click += new System.EventHandler(this.biletiptalbtn_Click);
            // 
            // iptaldatagrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.iptaldatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.iptaldatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.iptaldatagrid.BackgroundColor = System.Drawing.Color.White;
            this.iptaldatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iptaldatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.iptaldatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.iptaldatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.iptaldatagrid.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.iptaldatagrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.iptaldatagrid.EnableHeadersVisualStyles = false;
            this.iptaldatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.iptaldatagrid.Location = new System.Drawing.Point(42, 71);
            this.iptaldatagrid.Name = "iptaldatagrid";
            this.iptaldatagrid.RowHeadersVisible = false;
            this.iptaldatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.iptaldatagrid.Size = new System.Drawing.Size(767, 331);
            this.iptaldatagrid.TabIndex = 25;
            this.iptaldatagrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.iptaldatagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.iptaldatagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.iptaldatagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.iptaldatagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.iptaldatagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.iptaldatagrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.iptaldatagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.iptaldatagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.iptaldatagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.iptaldatagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.iptaldatagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.iptaldatagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.iptaldatagrid.ThemeStyle.HeaderStyle.Height = 4;
            this.iptaldatagrid.ThemeStyle.ReadOnly = false;
            this.iptaldatagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.iptaldatagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.iptaldatagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.iptaldatagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.iptaldatagrid.ThemeStyle.RowsStyle.Height = 22;
            this.iptaldatagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.iptaldatagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ustpanel
            // 
            this.ustpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustpanel.FillColor = System.Drawing.Color.DarkSlateGray;
            this.ustpanel.FillColor2 = System.Drawing.Color.Cyan;
            this.ustpanel.Location = new System.Drawing.Point(0, 0);
            this.ustpanel.Name = "ustpanel";
            this.ustpanel.ShadowDecoration.Parent = this.ustpanel;
            this.ustpanel.Size = new System.Drawing.Size(871, 48);
            this.ustpanel.TabIndex = 1;
            // 
            // BiletIptalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 471);
            this.Controls.Add(this.arkapanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BiletIptalForm";
            this.Text = "BiletIptalForm";
            this.Load += new System.EventHandler(this.BiletIptalForm_Load);
            this.arkapanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iptaldatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel arkapanel;
        private Guna.UI2.WinForms.Guna2GradientPanel ustpanel;
        private Guna.UI2.WinForms.Guna2DataGridView iptaldatagrid;
        private Guna.UI2.WinForms.Guna2Button biletiptalbtn;
    }
}