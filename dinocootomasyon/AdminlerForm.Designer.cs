namespace dinocootomasyon
{
    partial class AdminlerForm
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
            this.arkapanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guncellebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.admingrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.silbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.eklebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sifretextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.admintextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ustpanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.arkapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admingrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // arkapanel
            // 
            this.arkapanel.Controls.Add(this.guncellebtn);
            this.arkapanel.Controls.Add(this.admingrid);
            this.arkapanel.Controls.Add(this.silbtn);
            this.arkapanel.Controls.Add(this.eklebtn);
            this.arkapanel.Controls.Add(this.sifretextbox);
            this.arkapanel.Controls.Add(this.admintextbox);
            this.arkapanel.Controls.Add(this.ustpanel);
            this.arkapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arkapanel.FillColor = System.Drawing.Color.DarkSlateGray;
            this.arkapanel.FillColor2 = System.Drawing.Color.Cyan;
            this.arkapanel.Location = new System.Drawing.Point(0, 0);
            this.arkapanel.Name = "arkapanel";
            this.arkapanel.ShadowDecoration.Parent = this.arkapanel;
            this.arkapanel.Size = new System.Drawing.Size(871, 471);
            this.arkapanel.TabIndex = 1;
            // 
            // guncellebtn
            // 
            this.guncellebtn.Animated = true;
            this.guncellebtn.BackColor = System.Drawing.Color.Transparent;
            this.guncellebtn.BorderColor = System.Drawing.Color.Yellow;
            this.guncellebtn.BorderRadius = 5;
            this.guncellebtn.BorderThickness = 2;
            this.guncellebtn.CheckedState.Parent = this.guncellebtn;
            this.guncellebtn.CustomImages.Parent = this.guncellebtn;
            this.guncellebtn.FillColor = System.Drawing.Color.Teal;
            this.guncellebtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guncellebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncellebtn.ForeColor = System.Drawing.Color.Black;
            this.guncellebtn.HoverState.Parent = this.guncellebtn;
            this.guncellebtn.Location = new System.Drawing.Point(156, 294);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.ShadowDecoration.Parent = this.guncellebtn;
            this.guncellebtn.Size = new System.Drawing.Size(82, 41);
            this.guncellebtn.TabIndex = 27;
            this.guncellebtn.Text = "GÜNCELLE";
            this.guncellebtn.Click += new System.EventHandler(this.guna2GradientButton1_Click_1);
            // 
            // admingrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.admingrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.admingrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.admingrid.BackgroundColor = System.Drawing.Color.White;
            this.admingrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.admingrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.admingrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admingrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.admingrid.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.admingrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.admingrid.EnableHeadersVisualStyles = false;
            this.admingrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admingrid.Location = new System.Drawing.Point(386, 67);
            this.admingrid.Name = "admingrid";
            this.admingrid.RowHeadersVisible = false;
            this.admingrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.admingrid.Size = new System.Drawing.Size(384, 284);
            this.admingrid.TabIndex = 26;
            this.admingrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.admingrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.admingrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.admingrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.admingrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.admingrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.admingrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.admingrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admingrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.admingrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.admingrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.admingrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.admingrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.admingrid.ThemeStyle.HeaderStyle.Height = 4;
            this.admingrid.ThemeStyle.ReadOnly = false;
            this.admingrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.admingrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.admingrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.admingrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.admingrid.ThemeStyle.RowsStyle.Height = 22;
            this.admingrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.admingrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // silbtn
            // 
            this.silbtn.Animated = true;
            this.silbtn.BackColor = System.Drawing.Color.Transparent;
            this.silbtn.BorderColor = System.Drawing.Color.Red;
            this.silbtn.BorderRadius = 5;
            this.silbtn.BorderThickness = 2;
            this.silbtn.CheckedState.Parent = this.silbtn;
            this.silbtn.CustomImages.Parent = this.silbtn;
            this.silbtn.FillColor = System.Drawing.Color.Teal;
            this.silbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.silbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbtn.ForeColor = System.Drawing.Color.Black;
            this.silbtn.HoverState.Parent = this.silbtn;
            this.silbtn.Location = new System.Drawing.Point(228, 235);
            this.silbtn.Name = "silbtn";
            this.silbtn.ShadowDecoration.Parent = this.silbtn;
            this.silbtn.Size = new System.Drawing.Size(78, 41);
            this.silbtn.TabIndex = 5;
            this.silbtn.Text = "SİL";
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // eklebtn
            // 
            this.eklebtn.Animated = true;
            this.eklebtn.BackColor = System.Drawing.Color.Transparent;
            this.eklebtn.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.eklebtn.BorderRadius = 5;
            this.eklebtn.BorderThickness = 2;
            this.eklebtn.CheckedState.Parent = this.eklebtn;
            this.eklebtn.CustomImages.Parent = this.eklebtn;
            this.eklebtn.FillColor = System.Drawing.Color.Teal;
            this.eklebtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eklebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklebtn.ForeColor = System.Drawing.Color.Black;
            this.eklebtn.HoverState.Parent = this.eklebtn;
            this.eklebtn.Location = new System.Drawing.Point(93, 235);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.ShadowDecoration.Parent = this.eklebtn;
            this.eklebtn.Size = new System.Drawing.Size(78, 41);
            this.eklebtn.TabIndex = 4;
            this.eklebtn.Text = "EKLE";
            this.eklebtn.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // sifretextbox
            // 
            this.sifretextbox.AutoRoundedCorners = true;
            this.sifretextbox.BackColor = System.Drawing.Color.Transparent;
            this.sifretextbox.BorderRadius = 17;
            this.sifretextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifretextbox.DefaultText = "Şifre";
            this.sifretextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sifretextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sifretextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sifretextbox.DisabledState.Parent = this.sifretextbox;
            this.sifretextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sifretextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sifretextbox.FocusedState.Parent = this.sifretextbox;
            this.sifretextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sifretextbox.HoverState.Parent = this.sifretextbox;
            this.sifretextbox.IconLeft = global::dinocootomasyon.Properties.Resources.Varlık_17;
            this.sifretextbox.Location = new System.Drawing.Point(71, 180);
            this.sifretextbox.Name = "sifretextbox";
            this.sifretextbox.PasswordChar = '\0';
            this.sifretextbox.PlaceholderText = "";
            this.sifretextbox.SelectedText = "";
            this.sifretextbox.SelectionStart = 5;
            this.sifretextbox.ShadowDecoration.Parent = this.sifretextbox;
            this.sifretextbox.Size = new System.Drawing.Size(250, 36);
            this.sifretextbox.TabIndex = 3;
            this.sifretextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sifretextbox_KeyPress);
            this.sifretextbox.Leave += new System.EventHandler(this.sifretextbox_Leave);
            // 
            // admintextbox
            // 
            this.admintextbox.AutoRoundedCorners = true;
            this.admintextbox.BackColor = System.Drawing.Color.Transparent;
            this.admintextbox.BorderRadius = 17;
            this.admintextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.admintextbox.DefaultText = "Admin";
            this.admintextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.admintextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.admintextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.admintextbox.DisabledState.Parent = this.admintextbox;
            this.admintextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.admintextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.admintextbox.FocusedState.Parent = this.admintextbox;
            this.admintextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.admintextbox.HoverState.Parent = this.admintextbox;
            this.admintextbox.IconLeft = global::dinocootomasyon.Properties.Resources.Varlık_16;
            this.admintextbox.Location = new System.Drawing.Point(71, 124);
            this.admintextbox.Name = "admintextbox";
            this.admintextbox.PasswordChar = '\0';
            this.admintextbox.PlaceholderText = "";
            this.admintextbox.SelectedText = "";
            this.admintextbox.SelectionStart = 5;
            this.admintextbox.ShadowDecoration.Parent = this.admintextbox;
            this.admintextbox.Size = new System.Drawing.Size(250, 36);
            this.admintextbox.TabIndex = 2;
            this.admintextbox.TextChanged += new System.EventHandler(this.admintextbox_TextChanged);
            this.admintextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.admintextbox_KeyPress);
            this.admintextbox.Leave += new System.EventHandler(this.admintextbox_Leave);
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
            // AdminlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 471);
            this.Controls.Add(this.arkapanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminlerForm";
            this.Text = "AdminlerForm";
            this.Load += new System.EventHandler(this.AdminlerForm_Load);
            this.arkapanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.admingrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel ustpanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox sifretextbox;
        private Guna.UI2.WinForms.Guna2TextBox admintextbox;
        private Guna.UI2.WinForms.Guna2GradientPanel arkapanel;
        private Guna.UI2.WinForms.Guna2GradientButton silbtn;
        private Guna.UI2.WinForms.Guna2GradientButton eklebtn;
        private Guna.UI2.WinForms.Guna2DataGridView admingrid;
        private Guna.UI2.WinForms.Guna2GradientButton guncellebtn;
    }
}