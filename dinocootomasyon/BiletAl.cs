using System;
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
    public partial class BiletAl : Form
    {
        public BiletAl()
        {
            InitializeComponent();
        }

        public static string tc = "", ad = "", soyad = "", biletsatan = "", yas = "", telefon = "", cinsiyet = "", sefernereden = "", sefernereye = "", adı = "", sefersaat = "", sefertarih = "", arac = "", arac_fiyat = "", seferid = "", bilet_nom = "";

        private void soyadtextbox_Leave(object sender, EventArgs e)
        {
            if (soyadtextbox.Text == "")
            {
                soyadtextbox.Text = "Soyad";
            }
        }

        private void adtextbox_Leave(object sender, EventArgs e)
        {
            if (adtextbox.Text == "")
            {
                adtextbox.Text = "Ad";
            }
        }

        private void tctextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tctextbox.Text == "T.C. Kimlik Numarası")
            {
                tctextbox.Text = "";
            }
        }

        private void soyadtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (soyadtextbox.Text == "Soyad")
            {
                soyadtextbox.Text = "";
            }
        }

        private void adtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (adtextbox.Text == "Ad")
            {
                adtextbox.Text = "";
            }
        }

        private void tctextbox_Leave(object sender, EventArgs e)
        {
            if (tctextbox.Text == "")
            {
                tctextbox.Text = "T.C. Kimlik Numarası";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tc = tctextbox.Text;

            sefersaat = sefersaatcombobox.Text;
            ad = adtextbox.Text;
            soyad = soyadtextbox.Text;
            biletsatan = "Admin";
            yas = yascombobox.Text;
            cinsiyet = cinsiyettcombobox.Text;
            telefon = telefontextbox.Text;
            sefernereden = seferneredencombobox.Text.ToLower();
            sefernereye = sefernereyecombobox.Text.ToLower();
            sefertarih = sefertarihcombobox.Text;
            arac = aracturucombobox.Text;

            if (ad == "" || ad == "Ad" || soyad == "" || soyad == "Soyad" || tc == "" || tc == "T.C. Kimlik Numarası" || yas == "Yaş" || cinsiyet == "Cinsiyet")
            {
                UyariForm uyari = new UyariForm();
                UyariForm.durum = "Uyarı";
                UyariForm.baslik = "BAŞARISIZ";
                UyariForm.uyaritext = "Bilgiler Hatalı !";
                uyari.Show();
            }
            else
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();

                SqlCommand komut = new SqlCommand("select * from sefer where sefer_saati = '" + sefersaat + "'and sefer_tarihi = '" + sefertarih + "'and sefer_nereden = '" + sefernereden + "'and sefer_nereye = '" + sefernereye + "'and arac_adi='" + arac + "'", SqlBaglanti.baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    seferid = oku["id"].ToString();
                    KoltukForm koltuk = new KoltukForm();
                    koltuk.Show();
                    SqlBaglanti.baglanti.Close();
                    SqlBaglanti.baglanti.Close();
                    UyariForm uyari = new UyariForm();
                    UyariForm.durum = "Onay";
                    UyariForm.baslik = "BAŞARILI";
                    UyariForm.uyaritext = "Koltuk Seçiniz.";
                    uyari.Show();
                }

                else
                {
                    UyariForm uyari = new UyariForm();
                    UyariForm.durum = "Uyarı";
                    UyariForm.baslik = "BAŞARISIZ";
                    UyariForm.uyaritext = "Böyle bir sefer bulunmamaktadır  !";
                    uyari.Show();
                    sefereklebtn.Enabled = true;
                }
            }




        }

        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        public void griddoldur()
        {

            da = new SqlDataAdapter("select * from sefer", SqlBaglanti.baglanti);
            ds = new DataSet();
            SqlBaglanti.baglanti.Open();
            da.Fill(ds, "sefer");
            seferlerdatagrid.DataSource = ds.Tables["sefer"];
            SqlBaglanti.baglanti.Close();
            seferlerdatagrid.Columns[0].Visible = false; //KOLON GİZLEME
            seferlerdatagrid.Columns[1].Visible = false; //KOLON GİZLEME
            seferlerdatagrid.Columns[2].Visible = false; //KOLON GİZLEME

        }

        private void seferneredencombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sefereklebtn_Click(object sender, EventArgs e)
        {

            try
            {
                sefersaat = sefersaatcombobox.Text;
                ad = adtextbox.Text;
                soyad = soyadtextbox.Text;
                biletsatan = "Admin";
                yas = yascombobox.Text;
                cinsiyet = cinsiyettcombobox.Text;
                telefon = telefontextbox.Text;
                sefernereden = seferneredencombobox.Text.ToLower();
                sefernereye = sefernereyecombobox.Text.ToLower();
                sefertarih = sefertarihcombobox.Text;
                arac = aracturucombobox.Text;

                if (sefersaat != "" && sefernereden != "" && sefernereye != "" && sefersaat != "" && arac != "")
                {
                    SqlBaglanti.baglanti.Close();
                    SqlBaglanti.baglanti.Open();
                    string aracid = "";
                    SqlCommand komut = new SqlCommand("SELECT * FROM arac WHERE arac_adi='" + aracturucombobox.Text + "'", SqlBaglanti.baglanti);
                    SqlDataReader oku = komut.ExecuteReader();
                    if (oku.Read())
                    {
                        aracid = oku["id"].ToString();
                    }


                    SqlBaglanti.baglanti.Close();
                    SqlBaglanti.baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Insert into sefer (arac_id,arac_adi,sefer_saati,sefer_tarihi,sefer_nereden,sefer_nereye ) values ('" + aracid + "','" + arac + "','" + sefersaat + "','" + sefertarih + "','" + sefernereden + "','" + sefernereye + "')", SqlBaglanti.baglanti);
                    cmd.ExecuteNonQuery();
                    SqlBaglanti.baglanti.Close();
                    griddoldur();

                    UyariForm uyari = new UyariForm();
                    UyariForm.durum = "Onay";
                    UyariForm.baslik = "BAŞARILI";
                    UyariForm.uyaritext = "Sefer Ekleme İşlemi\nbaşarılı bir şekilde tamamlandı.";
                    uyari.Show();
                }
                else
                {
                    UyariForm uyari = new UyariForm();
                    UyariForm.durum = "Uyarı";
                    UyariForm.baslik = "BAŞARISIZ";
                    UyariForm.uyaritext = "Boş alanları doldurunuz.";
                    uyari.Show();
                }




            }
            catch (Exception hata)
            {

                UyariForm uyari = new UyariForm();
                UyariForm.durum = "Uyari";
                UyariForm.baslik = "BAŞARISIZ";
                UyariForm.uyaritext = "Sefer Ekleme İşlemi\nsırasında teknik bir hata meydana geldi.";
                uyari.Show();

                sefereklebtn.Enabled = false;
            }
        }


        private void BiletAl_Load(object sender, EventArgs e)
        {
            griddoldur();


            // textBox6.Text = Login.k_adi;
            seferneredencombobox.Items.Clear();
            sefernereyecombobox.Items.Clear();
            SqlBaglanti.baglanti.Open();
            komut = new SqlCommand("Select * from City", SqlBaglanti.baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                seferneredencombobox.Items.Add(oku["name"].ToString());
                sefernereyecombobox.Items.Add(oku["name"].ToString());



            }
            SqlBaglanti.baglanti.Close();
            aracturucombobox.Items.Clear();
            SqlBaglanti.baglanti.Open();
            SqlCommand komutt = new SqlCommand("Select * from arac", SqlBaglanti.baglanti);
            SqlDataReader oku2 = komutt.ExecuteReader();
            while (oku2.Read())
            {

                aracturucombobox.Items.Add(oku2["arac_adi"].ToString());




            }
            SqlBaglanti.baglanti.Close();
        }


        private void sefertarihcombobox_ValueChanged(object sender, EventArgs e)
        {
            sefersaatcombobox.Text = sefertarihcombobox.Value.Date.ToString("dd/MM/yyyy");


        }

        private void aracturucombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlBaglanti.baglanti.Open();
            SqlCommand komutt = new SqlCommand("Select * from arac where arac_adi='" + aracturucombobox.Text + "'", SqlBaglanti.baglanti);
            SqlDataReader oku2 = komutt.ExecuteReader();
            while (oku2.Read())
            {

                arac_fiyat = oku2["bilet_fiyat"].ToString();




            }
            SqlBaglanti.baglanti.Close();
        }
    }
}
