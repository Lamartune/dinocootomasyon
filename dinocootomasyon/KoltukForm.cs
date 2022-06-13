using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dinocootomasyon
{
    public partial class KoltukForm : Form
    {
        public KoltukForm()
        {   
            InitializeComponent();
        }

        public string tarih = BiletAl.sefertarih;
        public string tarih_saat = BiletAl.sefersaat;
        string adısoyadi = BiletAl.ad + " " + BiletAl.soyad;
        string arac_adi = BiletAl.arac;
        int tutar;
        int bilet_fiyat = int.Parse(BiletAl.arac_fiyat.ToString());
        string ucret;
        ArrayList koltuklar = new ArrayList();
        ArrayList iptalKoltuk = new ArrayList();
        int arac_id = 0;
        int sefer_id = 0;

        void koltukYazdir()
        {
            string koltuk = "";
            for (int i = 0; i < koltuklar.Count; i++)
            {
                koltuk += koltuklar[i].ToString() + ",";
            }
            if (koltuklar.Count >= 1)
            {
                koltuk = koltuk.Remove(koltuk.Length - 1, 1);


            }
            txtKoltukNo.Text = koltuk;
        }

        string araGetir(string sql)
        {
            SqlBaglanti.baglanti.Close();
            SqlBaglanti.baglanti.Open();
            SqlCommand cmd = new SqlCommand(sql, SqlBaglanti.baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            oku.Read();
            string deger = oku[0].ToString();
            SqlBaglanti.baglanti.Close();
            return deger;
        }
        void VeriAl()
        {
            
            SqlBaglanti.baglanti.Open();
            //string sql = "SELECT * FROM satis WHERE arac_id=" + arac_id + " AND sefer_id=" + sefer_id + " AND sefer_tarihi=" + tarih + "AND sefer_saati='"+ tarih_saat +"'";
            SqlCommand cmd = new SqlCommand("select * from satis where sefer_id='" + BiletAl.seferid + "'", SqlBaglanti.baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                string koltuk_No = oku[5].ToString();
               
                Button btns = this.Controls.Find("Button" + koltuk_No, true).FirstOrDefault() as Button;
                btns.BackgroundImage = dinocootomasyon.Properties.Resources.dolu;
                btns.ForeColor = Color.Red;
                btns.Enabled = false;
            }
            SqlBaglanti.baglanti.Close();//
        }

        void biletAyir()
        {
            
            SqlBaglanti.baglanti.Open();

            string biletfiyat = "60";
            for (int i = 0; i < koltuklar.Count; i++)
            {

                //   string sql = "Insert into bilet_tablosu (tc,ad,soyad,k_adi,yas,telefon,cinsiyet,nerden,nereye,saat,biletadeti,fiyat,tarih,bilet_no ) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox6.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Text + "','" + textBox8.Text + "')";

                //  string sql = "INSERT INTO satis(arac_id,sefer_id,sefer_tarihi,sefer_saati,koltuk_No,ucret,satis_Adi,satis_Soyadi) VALUES (" + arac_id + "," + sefer_id + ",'" +tarih + "','" + tarih_saat + "','" + Convert.ToInt32(koltuklar[i]).ToString() + "','" + ucret + "'," + biletal.ad + ",'" + biletal.soyad + "')";
                SqlCommand cmd = new SqlCommand("Insert into satis (arac_id,sefer_id,sefer_tarihi,sefer_saati,koltuk_No,ucret,satis_Adi,satis_Soyadi,tc,yas,telefon,cinsiyet ) values ('" + arac_id + "','" + BiletAl.seferid + "','" + tarih + "','" + tarih_saat + "','" + Convert.ToInt32(koltuklar[i]).ToString() + "','" + biletfiyat + "','" + BiletAl.ad + "','" + BiletAl.soyad + "','" + BiletAl.tc + "','" + BiletAl.yas + "','" + BiletAl.telefon + "','" + BiletAl.cinsiyet + "')", SqlBaglanti.baglanti);
                cmd.ExecuteNonQuery();
                Button btns = this.Controls.Find("Button" + koltuklar[i].ToString(), true).FirstOrDefault() as Button;
                btns.BackgroundImage = dinocootomasyon.Properties.Resources.dolu;
                btns.ForeColor = Color.Red;
                
            }

            SqlBaglanti.baglanti.Close();
        }

        private void arkapanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            saat_lbl.Text = DateTime.Now.ToLongTimeString();
            tarih_lbl.Text = DateTime.Now.ToShortDateString();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            if (txtKoltukNo.Text != "")
            {

                biletAyir();
                this.Hide();
                UyariForm uyari = new UyariForm();
                UyariForm.durum = "Onay";
                UyariForm.baslik = "BAŞARILI";
                UyariForm.uyaritext = BiletAl.ad + " " + BiletAl.soyad + " bilgili kişinin\n " + txtKoltukNo.Text + " no'lu koltukları ayrılmıştır";
                uyari.Show();
            }
            else
            {
                UyariForm uyari = new UyariForm();
                UyariForm.durum = "Uyarı";
                UyariForm.baslik = "BAŞARISIZ";
                UyariForm.uyaritext = "Koltuk numarasını seçmediniz.";
                uyari.Show();
            }
        }
      
        private void btnKoltuk_Click(object sender, EventArgs e)
        {


            if (((Button)sender).ForeColor == Color.Black) // siyah
            {
                ((Button)sender).ForeColor = Color.Green;
                ((Button)sender).BackgroundImage = dinocootomasyon.Properties.Resources.secili;
                if (!koltuklar.Contains(((Button)sender).Text))
                {
                    koltuklar.Add(((Button)sender).Text);
                }
                tutar = tutar + bilet_fiyat;
                ucret = tutar.ToString();
                label3.Text = ucret;
                koltukYazdir();

            }
            else if (((Button)sender).ForeColor == Color.Green) // yeşil
            {
                ((Button)sender).BackgroundImage = dinocootomasyon.Properties.Resources.bos;
                ((Button)sender).ForeColor = Color.Black;
                if (koltuklar.Contains(((Button)sender).Text))
                {
                    koltuklar.Remove(((Button)sender).Text);
                    tutar = tutar - bilet_fiyat;
                    ucret = tutar.ToString();
                    label3.Text = ucret;
                }

            }
            else // kırmızı
            {
                if (!iptalKoltuk.Contains(((Button)sender).Text))
                {
                    iptalKoltuk.Add(((Button)sender).Text);

                }
                else
                {
                    iptalKoltuk.Remove(((Button)sender).Text);
                    tutar = tutar - bilet_fiyat;
                    ucret = tutar.ToString();
                    label3.Text = ucret;
                }

                string koltuk = "";
                for (int i = 0; i < iptalKoltuk.Count; i++)
                {
                    koltuk += iptalKoltuk[i].ToString() + ",";
                }
                if (iptalKoltuk.Count >= 1)
                {
                    koltuk = koltuk.Remove(koltuk.Length - 1, 1);
                }
               
            }
        }
        
        private void KoltukForm_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            arac_id = Convert.ToInt32(araGetir("SELECT * FROM arac WHERE arac_adi='" + arac_adi + "'"));
            sefer_id = Convert.ToInt32(araGetir("SELECT * FROM arac WHERE arac_adi='" + arac_adi + "'"));
            //sefer_id = Convert.ToInt32(araGetir("SELECT id FROM sefer WHERE arac_adi='" + arac_adi + "' and sefer_saati='" + arac_adi + "' and sefer_tarihi='" + arac_adi + "' and sefer_nereden='" + arac_adi + "' and sefer_nereye='" + arac_adi + "'"));
            sefer_id = 2;
            VeriAl();
            adısoyadi = BiletAl.ad;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBilet_iptal_Click(object sender, EventArgs e)
        {

        }
    }
}
