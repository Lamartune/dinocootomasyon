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
    public partial class BiletIptalForm : Form
    {
        public BiletIptalForm()
        {
            InitializeComponent();
        }
        DataSet dset = new DataSet();

        public void doldur()
        {
            SqlBaglanti.baglanti.Open();
            dset.Clear();

            SqlDataAdapter adtr2 = new SqlDataAdapter("select * From  satis ORDER BY id DESC", SqlBaglanti.baglanti);

            adtr2.Fill(dset, "kullanici");

            iptaldatagrid.DataSource = dset.Tables["kullanici"];

            adtr2.Dispose();
            iptaldatagrid.RowHeadersVisible = false; //En Baştaki Boş Kolonun Gizlenmesini sağlar 
            iptaldatagrid.Columns[0].Visible = false;
            //bazı gereksiz kısımları görünmez yaptık görüntü güzelleştirmek açısından "id şifre gibi."
            iptaldatagrid.MultiSelect = false;//birden fazla satır seçielemez
            iptaldatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // seçdiğimiz datagrid satırı tamamen satırca seçilmiş görülür


            SqlBaglanti.baglanti.Close();
        }
        private void biletiptalbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlBaglanti.baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from satis where id='" + iptaldatagrid.CurrentRow.Cells["id"].Value.ToString() + "'", SqlBaglanti.baglanti);
                komut.ExecuteNonQuery();
                UyariForm uyari = new UyariForm();
                UyariForm.durum = "Onay";
                UyariForm.baslik = "BAŞARILI";
                UyariForm.uyaritext = "Silme İşlemi Tamamlandı";
                uyari.Show();
                SqlBaglanti.baglanti.Close();
                doldur();
            }
            catch (Exception hata)
            {
                UyariForm uyari = new UyariForm();
                UyariForm.durum = "Uyarı";
                UyariForm.baslik = "BAŞARISIZ";
                UyariForm.uyaritext = "İptal işlemi tamamlanamadı.";
                uyari.Show();
            }
        }

        private void BiletIptalForm_Load(object sender, EventArgs e)
        {
            doldur();

        }
    }
}
