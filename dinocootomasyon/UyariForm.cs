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
    public partial class UyariForm : Form
    {
        public static string durum="",baslik,uyaritext;
        public UyariForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void uyariustpanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void UyariYazdir(String baslik, String uyaritext)
        {
            uyarilabel.Text = uyaritext;
            uyaribasliklabel.Text = baslik;
            wrongpng.Visible = true;
        }
        public void OnayYazdir(String baslik, String uyaritext)
        {
            checkpng.Visible = true;
            uyarilabel.Text = uyaritext;
            uyaribasliklabel.Text = baslik;
        }

        private void uyariform_Load(object sender, EventArgs e)
        {
            if(durum=="Uyarı")
            {
                UyariYazdir(baslik, uyaritext);
            }
            else if(durum=="Onay")
            {
                OnayYazdir(baslik, uyaritext);
            }
            
        }

        private void wrongpng_Click(object sender, EventArgs e)
        {

        }

        private void seferlerbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
