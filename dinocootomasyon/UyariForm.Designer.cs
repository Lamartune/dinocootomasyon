namespace dinocootomasyon
{
    partial class UyariForm
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
            this.uyaripanel = new Guna.UI2.WinForms.Guna2Panel();
            this.uyarilabel = new Guna.UI.WinForms.GunaLabel();
            this.wrongpng = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.checkpng = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.seferlerbtn = new Guna.UI2.WinForms.Guna2Button();
            this.uyariustpanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.uyaribasliklabel = new Guna.UI.WinForms.GunaLabel();
            this.uyaripanelclosebtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.uyaripanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrongpng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkpng)).BeginInit();
            this.uyariustpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uyaripanel
            // 
            this.uyaripanel.BackColor = System.Drawing.Color.White;
            this.uyaripanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uyaripanel.Controls.Add(this.uyarilabel);
            this.uyaripanel.Controls.Add(this.wrongpng);
            this.uyaripanel.Controls.Add(this.checkpng);
            this.uyaripanel.Controls.Add(this.seferlerbtn);
            this.uyaripanel.Controls.Add(this.uyariustpanel);
            this.uyaripanel.Location = new System.Drawing.Point(-16, -15);
            this.uyaripanel.Name = "uyaripanel";
            this.uyaripanel.ShadowDecoration.Parent = this.uyaripanel;
            this.uyaripanel.Size = new System.Drawing.Size(430, 244);
            this.uyaripanel.TabIndex = 0;
            // 
            // uyarilabel
            // 
            this.uyarilabel.AutoSize = true;
            this.uyarilabel.Font = new System.Drawing.Font("Exo 2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyarilabel.Location = new System.Drawing.Point(98, 96);
            this.uyarilabel.Name = "uyarilabel";
            this.uyarilabel.Size = new System.Drawing.Size(90, 28);
            this.uyarilabel.TabIndex = 8;
            this.uyarilabel.Text = "uyaritext";
            // 
            // wrongpng
            // 
            this.wrongpng.BackColor = System.Drawing.Color.Transparent;
            this.wrongpng.BaseColor = System.Drawing.Color.Black;
            this.wrongpng.Image = global::dinocootomasyon.Properties.Resources.x_mark;
            this.wrongpng.Location = new System.Drawing.Point(28, 81);
            this.wrongpng.Name = "wrongpng";
            this.wrongpng.Size = new System.Drawing.Size(64, 67);
            this.wrongpng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wrongpng.TabIndex = 7;
            this.wrongpng.TabStop = false;
            this.wrongpng.Visible = false;
            this.wrongpng.Click += new System.EventHandler(this.wrongpng_Click);
            // 
            // checkpng
            // 
            this.checkpng.BackColor = System.Drawing.Color.Transparent;
            this.checkpng.BaseColor = System.Drawing.Color.Black;
            this.checkpng.Image = global::dinocootomasyon.Properties.Resources.check_mark;
            this.checkpng.Location = new System.Drawing.Point(28, 81);
            this.checkpng.Name = "checkpng";
            this.checkpng.Size = new System.Drawing.Size(64, 67);
            this.checkpng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkpng.TabIndex = 6;
            this.checkpng.TabStop = false;
            this.checkpng.Visible = false;
            // 
            // seferlerbtn
            // 
            this.seferlerbtn.Animated = true;
            this.seferlerbtn.AutoRoundedCorners = true;
            this.seferlerbtn.BackColor = System.Drawing.Color.Transparent;
            this.seferlerbtn.BackgroundImage = global::dinocootomasyon.Properties.Resources.tamambtn;
            this.seferlerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seferlerbtn.BorderRadius = 17;
            this.seferlerbtn.CheckedState.Parent = this.seferlerbtn;
            this.seferlerbtn.CustomImages.Parent = this.seferlerbtn;
            this.seferlerbtn.FillColor = System.Drawing.Color.Transparent;
            this.seferlerbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.seferlerbtn.ForeColor = System.Drawing.Color.Transparent;
            this.seferlerbtn.HoverState.Parent = this.seferlerbtn;
            this.seferlerbtn.Location = new System.Drawing.Point(129, 163);
            this.seferlerbtn.Name = "seferlerbtn";
            this.seferlerbtn.ShadowDecoration.Parent = this.seferlerbtn;
            this.seferlerbtn.Size = new System.Drawing.Size(150, 37);
            this.seferlerbtn.TabIndex = 5;
            this.seferlerbtn.Text = "guna2Button3";
            this.seferlerbtn.Click += new System.EventHandler(this.seferlerbtn_Click);
            // 
            // uyariustpanel
            // 
            this.uyariustpanel.Controls.Add(this.uyaribasliklabel);
            this.uyariustpanel.Controls.Add(this.uyaripanelclosebtn);
            this.uyariustpanel.FillColor = System.Drawing.Color.Cyan;
            this.uyariustpanel.FillColor2 = System.Drawing.Color.Gray;
            this.uyariustpanel.Location = new System.Drawing.Point(13, 15);
            this.uyariustpanel.Name = "uyariustpanel";
            this.uyariustpanel.ShadowDecoration.Parent = this.uyariustpanel;
            this.uyariustpanel.Size = new System.Drawing.Size(388, 42);
            this.uyariustpanel.TabIndex = 0;
            this.uyariustpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uyariustpanel_MouseDown);
            // 
            // uyaribasliklabel
            // 
            this.uyaribasliklabel.AutoSize = true;
            this.uyaribasliklabel.BackColor = System.Drawing.Color.Transparent;
            this.uyaribasliklabel.Font = new System.Drawing.Font("Exo 2", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyaribasliklabel.Location = new System.Drawing.Point(8, 0);
            this.uyaribasliklabel.Name = "uyaribasliklabel";
            this.uyaribasliklabel.Size = new System.Drawing.Size(92, 39);
            this.uyaribasliklabel.TabIndex = 9;
            this.uyaribasliklabel.Text = "Başlık";
            // 
            // uyaripanelclosebtn
            // 
            this.uyaripanelclosebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uyaripanelclosebtn.Animated = true;
            this.uyaripanelclosebtn.BackColor = System.Drawing.Color.Transparent;
            this.uyaripanelclosebtn.BorderColor = System.Drawing.Color.Transparent;
            this.uyaripanelclosebtn.FillColor = System.Drawing.Color.Transparent;
            this.uyaripanelclosebtn.HoverState.Parent = this.uyaripanelclosebtn;
            this.uyaripanelclosebtn.IconColor = System.Drawing.Color.Black;
            this.uyaripanelclosebtn.Location = new System.Drawing.Point(321, 3);
            this.uyaripanelclosebtn.Name = "uyaripanelclosebtn";
            this.uyaripanelclosebtn.ShadowDecoration.Parent = this.uyaripanelclosebtn;
            this.uyaripanelclosebtn.Size = new System.Drawing.Size(52, 36);
            this.uyaripanelclosebtn.TabIndex = 0;
            this.uyaripanelclosebtn.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // UyariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 197);
            this.Controls.Add(this.uyaripanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UyariForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uyariform";
            this.Load += new System.EventHandler(this.uyariform_Load);
            this.uyaripanel.ResumeLayout(false);
            this.uyaripanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrongpng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkpng)).EndInit();
            this.uyariustpanel.ResumeLayout(false);
            this.uyariustpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel uyaripanel;
        private Guna.UI2.WinForms.Guna2GradientPanel uyariustpanel;
        private Guna.UI2.WinForms.Guna2ControlBox uyaripanelclosebtn;
        private Guna.UI2.WinForms.Guna2Button seferlerbtn;
        private Guna.UI.WinForms.GunaLabel uyarilabel;
        private Guna.UI.WinForms.GunaLabel uyaribasliklabel;
        public Guna.UI.WinForms.GunaTransfarantPictureBox wrongpng;
        public Guna.UI.WinForms.GunaTransfarantPictureBox checkpng;
    }
}