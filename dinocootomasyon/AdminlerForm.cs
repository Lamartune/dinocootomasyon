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
    public partial class AdminlerForm : Form
    {
        public AdminlerForm()
        {
            InitializeComponent();
        }
        DataSet dset = new DataSet();

        public void doldur()
        {
            SqlBaglanti.baglanti.Open();
            dset.Clear();

            SqlDataAdapter adtr2 = new SqlDataAdapter("select * From  admin ORDER BY id DESC", SqlBaglanti.baglanti);

            adtr2.Fill(dset, "kullanici");

            admingrid.DataSource = dset.Tables["kullanici"];

            adtr2.Dispose();
            admingrid.RowHeadersVisible = false; //En Baştaki Boş Kolonun Gizlenmesini sağlar 
            admingrid.Columns[0].Visible = false;
            //bazı gereksiz kısımları görünmez yapar görüntü güzelleştirmek açısından "id şifre gibi."
            admingrid.MultiSelect = false;//birden fazla satır seçielemez
            admingrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // seçdiğimiz datagrid satırı tamamen satırca seçilmiş görülür


            SqlBaglanti.baglanti.Close();
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(admintextbox.Text =="" || sifretextbox.Text =="" || admintextbox.Text == null || sifretextbox.Text == null)
            {

            }
            else
            {
                SqlBaglanti.baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into admin(k_adi,sifre) values('" + admintextbox.Text + "','" + sifretextbox.Text + "')", SqlBaglanti.baglanti);
                ekle.ExecuteNonQuery();
                SqlBaglanti.baglanti.Close();
                UyariForm uyari = new UyariForm();
                UyariForm.durum = "Onay";
                UyariForm.baslik = "BAŞARILI";
                UyariForm.uyaritext = "Ekleme İşlemi Başarılı";
                uyari.Show();
                doldur();
            }
            
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlBaglanti.baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from admin where id='" + admingrid.CurrentRow.Cells["id"].Value.ToString() + "'", SqlBaglanti.baglanti);
                komut.ExecuteNonQuery();
                UyariForm uyari = new UyariForm();
                UyariForm.durum = "Onay";
                UyariForm.baslik = "BAŞARILI";
                UyariForm.uyaritext = "Silme İşleme Başarıyla Tamamlandı";
                uyari.Show();
                SqlBaglanti.baglanti.Close();
                doldur();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message); ;
            }
        }



        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            SqlBaglanti.baglanti.Open();

            SqlCommand guncelle = new SqlCommand("UPDATE admin set k_adi='" + admintextbox.Text + "',sifre='" + sifretextbox.Text + "' where id ='" + admingrid.CurrentRow.Cells["id"].Value.ToString() + "'", SqlBaglanti.baglanti);
            guncelle.ExecuteNonQuery();

            SqlBaglanti.baglanti.Close();
            UyariForm uyari = new UyariForm();
            UyariForm.durum = "Onay";
            UyariForm.baslik = "BAŞARILI";
            UyariForm.uyaritext = "Güncelleme İşlemi Başarılı";
            uyari.Show();
            doldur();
        }

        private void AdminlerForm_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void admintextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(admintextbox.Text == "Admin")
            {
                admintextbox.Text = "";
            }
        }

        private void admintextbox_Leave(object sender, EventArgs e)
        {
            if (admintextbox.Text == "")
            {
                admintextbox.Text = "Admin";
            }
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
                sifretextbox.Text = "Şifre";
                sifretextbox.PasswordChar = '\0';
            }
        
        }

        private void admintextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
