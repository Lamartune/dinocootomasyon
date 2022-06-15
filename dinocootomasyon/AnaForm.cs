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
using System.Data.SqlClient;

namespace dinocootomasyon
{
    public partial class AnaForm : Form
    {
        String kullaniciadi, sifre;
        public AnaForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void guna2ControlBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientPanel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            SqlBaglanti.baglanti.Close();
            kullaniciadi = admintextbox.Text;
            sifre = sifretextbox.Text;
            giriskayitpanel.Visible = true;

            //Boş Alan Kontrolü
            if (kullaniciadi.Equals("") || sifre.Equals("") /*|| mail.Equals("") || isimsoyisim.Equals("")*/ || kullaniciadi.Equals("Admin") || sifre.Equals("Şifre") /*|| mail.Equals("E-posta") || isimsoyisim.Equals("İsim Soyisim")*/)
            {
                UyariForm uyari = new UyariForm();
                UyariForm.durum = "Uyarı";
                UyariForm.baslik = "BAŞARISIZ";
                UyariForm.uyaritext = "Lütfen Boş alanları doldurunuz.";
                uyari.Show();
            }
            else
            {
                //Veritabanından admin girişi için kullanıcı adı alma
                SqlBaglanti.baglanti.Open();
                SqlCommand listeleseans = new SqlCommand("select * from admin where k_adi='" + admintextbox.Text + "' and sifre='" + sifretextbox.Text + "'", SqlBaglanti.baglanti);
                SqlDataReader drs = listeleseans.ExecuteReader();
                if (drs.Read())
                {
                    kullaniciadi = drs["k_adi"].ToString();
                    AdminForm admin = new AdminForm();
                    admin.Show();
                    this.Hide();
                    UyariForm uyari = new UyariForm();
                    UyariForm.durum = "Onay";
                    UyariForm.baslik = "BAŞARILI";
                    UyariForm.uyaritext = "Giriş Başarılı";
                    uyari.Show();
                    SqlBaglanti.baglanti.Close();
                }
                else
                {
                    UyariForm uyari = new UyariForm();
                    UyariForm.durum = "Uyarı";
                    UyariForm.baslik = "BAŞARISIZ";
                    UyariForm.uyaritext = "Kullanıcı Adı Şifre Hatalı";
                    uyari.Show();
                }

            }
        }

        private void tctextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kayitbtn_Click(object sender, EventArgs e)
        {
            giriskayitpanel.Visible = true;
            girisbtn.Visible = false;
            kayitgeribtn.Visible = true;


        }

        int b = 0;
        private void anasayfabtn_Click(object sender, EventArgs e)
        {
            giriskayitpanel.Visible = false;
            baslabtn.Visible = true;
            if (b == 0)
            {
                seferpanelanaform.Visible = false;
                seferpanelanaform.Controls.Clear();
            }
            else
            {
                seferpanelanaform.Refresh();
            }
        }


        int a = 0;
        private void seferlerbtn_Click(object sender, EventArgs e)
        {
            giriskayitpanel.Visible = false;

            baslabtn.Visible = false;
            seferpanelanaform.Visible = true;
            seferpanelanaform.Controls.Clear();
            //sefer formu çağırma işlemi
            SeferlerForm seferform = new SeferlerForm();
            seferform.TopLevel = false;
            seferpanelanaform.Controls.Add(seferform);
            seferform.Show();
            seferform.Dock = DockStyle.Fill;
            seferform.BringToFront();
            a = 1;




            giriskayitpanel.Refresh();
            a = 0;

        }

        private void giriskayitpanel_MouseEnter(object sender, EventArgs e)
        {
            //boş alan kontrolü
            if (admintextbox.Text.Equals(""))
            {
                admintextbox.Text = "Admin";
            }

            if (sifretextbox.Text.Equals(""))
            {
                sifretextbox.Text = "Şifre";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //başla butonu visible işlemleri
            giriskayitpanel.Visible = true;
            girisbtn.Visible = true;
            admintextbox.Visible = true;
            sifretextbox.Visible = true;
            baslabtn.Visible = false;
            kayitgeribtn.Visible = false;
        }

        private void admintextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (admintextbox.Text == "Admin")
            {
                admintextbox.Text = "";
            }
        }

        private void sifretextbox_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void sifretextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sifretextbox.Text == "Şifre")
            {
                sifretextbox.Text = "";
                sifretextbox.PasswordChar = '*';
            }
        }

        private void sifretextbox_Leave(object sender, EventArgs e)
        {
            if (sifretextbox.Text == "")
            {
                sifretextbox.Text = "";
                sifretextbox.PasswordChar = '\0';
            }
        }

        private void kayitgeribtn_MouseClick(object sender, MouseEventArgs e)
        {
            girisbtn.Visible = true;
            kayitgeribtn.Visible = false;
        }
    }
}
