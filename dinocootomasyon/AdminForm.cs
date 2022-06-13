using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinocootomasyon
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void ustpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ustpanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AnaForm anasayfa = new AnaForm();
            anasayfa.Show();
        }

        private void biletpanelbtn_Click(object sender, EventArgs e)
        {
            islempanel.Controls.Clear();
            BiletAl biletal = new BiletAl();
            biletal.TopLevel = false;
            islempanel.Controls.Add(biletal);
            biletal.Show();
            biletal.Dock = DockStyle.Fill;
            biletal.BringToFront();
        }

        private void kullanicipanelbtn_Click(object sender, EventArgs e)
        {
            islempanel.Controls.Clear();
            AdminlerForm adminform = new AdminlerForm();
            adminform.TopLevel = false;
            islempanel.Controls.Add(adminform);
            adminform.Show();
            adminform.Dock = DockStyle.Fill;
            adminform.BringToFront();
        }

        private void biletiptalbtn_Click(object sender, EventArgs e)
        {

            islempanel.Controls.Clear();
            BiletIptalForm iptal = new BiletIptalForm();
            iptal.TopLevel = false;
            islempanel.Controls.Add(iptal);
            iptal.Show();
            iptal.Dock = DockStyle.Fill;
            iptal.BringToFront();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
