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
    public partial class SeferlerForm : Form
    {
        public SeferlerForm()
        {
            InitializeComponent();
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
        private void SeferlerForm_Load(object sender, EventArgs e)
        {


           
            griddoldur();
        }
    }
}
