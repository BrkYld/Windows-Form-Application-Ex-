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

namespace MY_LIBRARY
{
    public partial class sifreDegis : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2QO10U0;Initial Catalog=MyLibrary;Persist Security Info=True;User ID=sa;Password=123369");
        SqlCommand sorgu;
        SqlDataReader dr;
        public String userNamee { get; set; }
        public sifreDegis()
        {
            InitializeComponent();
        }

        private void sifreDegis_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            sorgu = new SqlCommand("update Personel set sifre = @sif where kullaniciAdı = @cKad", baglanti);
            sorgu.Parameters.AddWithValue("@sif", sifre.Text);
            sorgu.Parameters.AddWithValue("@cKad", userNamee);
            sorgu.ExecuteNonQuery();

            sorgu = new SqlCommand("update Personel set kullaniciAdı = @ad where kullaniciAdı = @cKad", baglanti);
            sorgu.Parameters.AddWithValue("@ad", kullAdi.Text);
            sorgu.Parameters.AddWithValue("@cKad", userNamee);
            sorgu.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("GÜNCELLEME BAŞARILI !", "GÜNCELLE");
            this.Close();
            
        }
    }
}
