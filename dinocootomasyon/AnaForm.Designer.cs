namespace dinocootomasyon
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ustpanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.hidebtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closebtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.anapanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.giriskayitpanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.kayitgeribtn = new Guna.UI2.WinForms.Guna2Button();
            this.girisbtn = new Guna.UI2.WinForms.Guna2Button();
            this.sifretextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.admintextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.baslabtn = new Guna.UI2.WinForms.Guna2Button();
            this.seferpanelanaform = new Guna.UI2.WinForms.Guna2Panel();
            this.seferlerbtn = new Guna.UI2.WinForms.Guna2Button();
            this.anasayfabtn = new Guna.UI2.WinForms.Guna2Button();
            this.ustpanel.SuspendLayout();
            this.anapanel.SuspendLayout();
            this.giriskayitpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ustpanel
            // 
            this.ustpanel.Controls.Add(this.hidebtn);
            this.ustpanel.Controls.Add(this.closebtn);
            this.ustpanel.FillColor = System.Drawing.Color.Cyan;
            this.ustpanel.FillColor2 = System.Drawing.Color.Gray;
            this.ustpanel.Location = new System.Drawing.Point(-6, 0);
            this.ustpanel.Name = "ustpanel";
            this.ustpanel.ShadowDecoration.Parent = this.ustpanel;
            this.ustpanel.Size = new System.Drawing.Size(1066, 47);
            this.ustpanel.TabIndex = 3;
            this.ustpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2GradientPanel5_MouseDown);
            // 
            // hidebtn
            // 
            this.hidebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hidebtn.BackColor = System.Drawing.Color.Transparent;
            this.hidebtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.hidebtn.FillColor = System.Drawing.Color.Transparent;
            this.hidebtn.HoverState.Parent = this.hidebtn;
            this.hidebtn.IconColor = System.Drawing.Color.Black;
            this.hidebtn.Location = new System.Drawing.Point(921, 6);
            this.hidebtn.Name = "hidebtn";
            this.hidebtn.ShadowDecoration.Parent = this.hidebtn;
            this.hidebtn.Size = new System.Drawing.Size(66, 38);
            this.hidebtn.TabIndex = 2;
            this.hidebtn.Click += new System.EventHandler(this.guna2ControlBox8_Click);
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.FillColor = System.Drawing.Color.Transparent;
            this.closebtn.HoverState.Parent = this.closebtn;
            this.closebtn.IconColor = System.Drawing.Color.Black;
            this.closebtn.Location = new System.Drawing.Point(984, 6);
            this.closebtn.Name = "closebtn";
            this.closebtn.ShadowDecoration.Parent = this.closebtn;
            this.closebtn.Size = new System.Drawing.Size(68, 38);
            this.closebtn.TabIndex = 1;
            this.closebtn.Click += new System.EventHandler(this.guna2ControlBox8_Click);
            // 
            // anapanel
            // 
            this.anapanel.BackgroundImage = global::dinocootomasyon.Properties.Resources._2anaform;
            this.anapanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anapanel.Controls.Add(this.giriskayitpanel);
            this.anapanel.Controls.Add(this.baslabtn);
            this.anapanel.Controls.Add(this.seferpanelanaform);
            this.anapanel.Controls.Add(this.seferlerbtn);
            this.anapanel.Controls.Add(this.anasayfabtn);
            this.anapanel.Location = new System.Drawing.Point(-9, 33);
            this.anapanel.Name = "anapanel";
            this.anapanel.ShadowDecoration.Parent = this.anapanel;
            this.anapanel.Size = new System.Drawing.Size(1088, 725);
            this.anapanel.TabIndex = 1;
            // 
            // giriskayitpanel
            // 
            this.giriskayitpanel.BackColor = System.Drawing.Color.Transparent;
            this.giriskayitpanel.BackgroundImage = global::dinocootomasyon.Properties.Resources.giriskayitpanel;
            this.giriskayitpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.giriskayitpanel.BorderColor = System.Drawing.Color.Transparent;
            this.giriskayitpanel.Controls.Add(this.kayitgeribtn);
            this.giriskayitpanel.Controls.Add(this.girisbtn);
            this.giriskayitpanel.Controls.Add(this.sifretextbox);
            this.giriskayitpanel.Controls.Add(this.admintextbox);
            this.giriskayitpanel.Location = new System.Drawing.Point(317, 253);
            this.giriskayitpanel.Name = "giriskayitpanel";
            this.giriskayitpanel.ShadowDecoration.Parent = this.giriskayitpanel;
            this.giriskayitpanel.Size = new System.Drawing.Size(438, 250);
            this.giriskayitpanel.TabIndex = 7;
            this.giriskayitpanel.Visible = false;
            this.giriskayitpanel.MouseEnter += new System.EventHandler(this.giriskayitpanel_MouseEnter);
            // 
            // kayitgeribtn
            // 
            this.kayitgeribtn.Animated = true;
            this.kayitgeribtn.AutoRoundedCorners = true;
            this.kayitgeribtn.BackColor = System.Drawing.Color.Transparent;
            this.kayitgeribtn.BackgroundImage = global::dinocootomasyon.Properties.Resources.Varlık_32;
            this.kayitgeribtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kayitgeribtn.BorderRadius = 19;
            this.kayitgeribtn.CheckedState.Parent = this.kayitgeribtn;
            this.kayitgeribtn.CustomImages.Parent = this.kayitgeribtn;
            this.kayitgeribtn.FillColor = System.Drawing.Color.Transparent;
            this.kayitgeribtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kayitgeribtn.ForeColor = System.Drawing.Color.Transparent;
            this.kayitgeribtn.HoverState.Parent = this.kayitgeribtn;
            this.kayitgeribtn.Location = new System.Drawing.Point(35, 155);
            this.kayitgeribtn.Name = "kayitgeribtn";
            this.kayitgeribtn.ShadowDecoration.Parent = this.kayitgeribtn;
            this.kayitgeribtn.Size = new System.Drawing.Size(41, 41);
            this.kayitgeribtn.TabIndex = 11;
            this.kayitgeribtn.Text = "guna2Button4";
            this.kayitgeribtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kayitgeribtn_MouseClick);
            // 
            // girisbtn
            // 
            this.girisbtn.Animated = true;
            this.girisbtn.AutoRoundedCorners = true;
            this.girisbtn.BackColor = System.Drawing.Color.Transparent;
            this.girisbtn.BackgroundImage = global::dinocootomasyon.Properties.Resources.Varlık_29;
            this.girisbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.girisbtn.BorderRadius = 23;
            this.girisbtn.CheckedState.Parent = this.girisbtn;
            this.girisbtn.CustomImages.Parent = this.girisbtn;
            this.girisbtn.FillColor = System.Drawing.Color.Transparent;
            this.girisbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.girisbtn.ForeColor = System.Drawing.Color.Transparent;
            this.girisbtn.HoverState.Parent = this.girisbtn;
            this.girisbtn.ImageSize = new System.Drawing.Size(198, 49);
            this.girisbtn.Location = new System.Drawing.Point(110, 147);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.ShadowDecoration.Parent = this.girisbtn;
            this.girisbtn.Size = new System.Drawing.Size(198, 49);
            this.girisbtn.TabIndex = 5;
            this.girisbtn.Text = "guna2Button4";
            this.girisbtn.Visible = false;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // sifretextbox
            // 
            this.sifretextbox.AutoRoundedCorners = true;
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
            this.sifretextbox.Location = new System.Drawing.Point(90, 94);
            this.sifretextbox.Name = "sifretextbox";
            this.sifretextbox.PasswordChar = '\0';
            this.sifretextbox.PlaceholderText = "";
            this.sifretextbox.SelectedText = "";
            this.sifretextbox.SelectionStart = 5;
            this.sifretextbox.ShadowDecoration.Parent = this.sifretextbox;
            this.sifretextbox.Size = new System.Drawing.Size(250, 36);
            this.sifretextbox.TabIndex = 1;
            this.sifretextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sifretextbox_KeyPress);
            this.sifretextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sifretextbox_KeyUp);
            this.sifretextbox.Leave += new System.EventHandler(this.sifretextbox_Leave);
            // 
            // admintextbox
            // 
            this.admintextbox.AutoRoundedCorners = true;
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
            this.admintextbox.Location = new System.Drawing.Point(90, 38);
            this.admintextbox.Name = "admintextbox";
            this.admintextbox.PasswordChar = '\0';
            this.admintextbox.PlaceholderText = "";
            this.admintextbox.SelectedText = "";
            this.admintextbox.SelectionStart = 5;
            this.admintextbox.ShadowDecoration.Parent = this.admintextbox;
            this.admintextbox.Size = new System.Drawing.Size(250, 36);
            this.admintextbox.TabIndex = 0;
            this.admintextbox.TextChanged += new System.EventHandler(this.tctextbox_TextChanged);
            this.admintextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.admintextbox_KeyPress);
            // 
            // baslabtn
            // 
            this.baslabtn.Animated = true;
            this.baslabtn.AutoRoundedCorners = true;
            this.baslabtn.BackColor = System.Drawing.Color.Transparent;
            this.baslabtn.BackgroundImage = global::dinocootomasyon.Properties.Resources.baslabtn;
            this.baslabtn.BorderRadius = 24;
            this.baslabtn.CheckedState.Parent = this.baslabtn;
            this.baslabtn.CustomImages.Parent = this.baslabtn;
            this.baslabtn.FillColor = System.Drawing.Color.Transparent;
            this.baslabtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.baslabtn.ForeColor = System.Drawing.Color.Transparent;
            this.baslabtn.HoverState.Parent = this.baslabtn;
            this.baslabtn.Location = new System.Drawing.Point(159, 519);
            this.baslabtn.Name = "baslabtn";
            this.baslabtn.ShadowDecoration.Parent = this.baslabtn;
            this.baslabtn.Size = new System.Drawing.Size(199, 50);
            this.baslabtn.TabIndex = 9;
            this.baslabtn.Text = "baslabtn";
            this.baslabtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // seferpanelanaform
            // 
            this.seferpanelanaform.Location = new System.Drawing.Point(115, 115);
            this.seferpanelanaform.Name = "seferpanelanaform";
            this.seferpanelanaform.ShadowDecoration.Enabled = true;
            this.seferpanelanaform.ShadowDecoration.Parent = this.seferpanelanaform;
            this.seferpanelanaform.Size = new System.Drawing.Size(841, 508);
            this.seferpanelanaform.TabIndex = 8;
            this.seferpanelanaform.Visible = false;
            // 
            // seferlerbtn
            // 
            this.seferlerbtn.Animated = true;
            this.seferlerbtn.AutoRoundedCorners = true;
            this.seferlerbtn.BackColor = System.Drawing.Color.Transparent;
            this.seferlerbtn.BackgroundImage = global::dinocootomasyon.Properties.Resources.btnsefer;
            this.seferlerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seferlerbtn.BorderRadius = 15;
            this.seferlerbtn.CheckedState.Parent = this.seferlerbtn;
            this.seferlerbtn.CustomImages.Parent = this.seferlerbtn;
            this.seferlerbtn.FillColor = System.Drawing.Color.Transparent;
            this.seferlerbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.seferlerbtn.ForeColor = System.Drawing.Color.Transparent;
            this.seferlerbtn.HoverState.Parent = this.seferlerbtn;
            this.seferlerbtn.Location = new System.Drawing.Point(571, 35);
            this.seferlerbtn.Name = "seferlerbtn";
            this.seferlerbtn.ShadowDecoration.Parent = this.seferlerbtn;
            this.seferlerbtn.Size = new System.Drawing.Size(134, 33);
            this.seferlerbtn.TabIndex = 4;
            this.seferlerbtn.Text = "guna2Button3";
            this.seferlerbtn.Click += new System.EventHandler(this.seferlerbtn_Click);
            // 
            // anasayfabtn
            // 
            this.anasayfabtn.Animated = true;
            this.anasayfabtn.AutoRoundedCorners = true;
            this.anasayfabtn.BackColor = System.Drawing.Color.Transparent;
            this.anasayfabtn.BackgroundImage = global::dinocootomasyon.Properties.Resources.btnanasayfa;
            this.anasayfabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anasayfabtn.BorderRadius = 15;
            this.anasayfabtn.CheckedState.Parent = this.anasayfabtn;
            this.anasayfabtn.CustomImages.Parent = this.anasayfabtn;
            this.anasayfabtn.FillColor = System.Drawing.Color.Transparent;
            this.anasayfabtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.anasayfabtn.ForeColor = System.Drawing.Color.Transparent;
            this.anasayfabtn.HoverState.Parent = this.anasayfabtn;
            this.anasayfabtn.Location = new System.Drawing.Point(358, 35);
            this.anasayfabtn.Name = "anasayfabtn";
            this.anasayfabtn.ShadowDecoration.Parent = this.anasayfabtn;
            this.anasayfabtn.Size = new System.Drawing.Size(134, 33);
            this.anasayfabtn.TabIndex = 3;
            this.anasayfabtn.Text = "guna2Button2";
            this.anasayfabtn.Click += new System.EventHandler(this.anasayfabtn_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 700);
            this.Controls.Add(this.ustpanel);
            this.Controls.Add(this.anapanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anaform";
            this.ustpanel.ResumeLayout(false);
            this.anapanel.ResumeLayout(false);
            this.giriskayitpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel anapanel;
        private Guna.UI2.WinForms.Guna2GradientPanel ustpanel;
        private Guna.UI2.WinForms.Guna2ControlBox hidebtn;
        private Guna.UI2.WinForms.Guna2ControlBox closebtn;
        private Guna.UI2.WinForms.Guna2Button anasayfabtn;
        private Guna.UI2.WinForms.Guna2Button seferlerbtn;
        private Guna.UI2.WinForms.Guna2Button girisbtn;
        private Guna.UI2.WinForms.Guna2GradientPanel giriskayitpanel;
        private Guna.UI2.WinForms.Guna2TextBox admintextbox;
        private Guna.UI2.WinForms.Guna2TextBox sifretextbox;
        private Guna.UI2.WinForms.Guna2Panel seferpanelanaform;
        private Guna.UI2.WinForms.Guna2Button baslabtn;
        private Guna.UI2.WinForms.Guna2Button kayitgeribtn;
    }
}

