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
    public partial class yeniOgrForm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2QO10U0;Initial Catalog=MyLibrary;Persist Security Info=True;User ID=sa;Password=123369");
        SqlCommand sorgu;
        SqlDataReader dr;
        public yeniOgrForm()
        {
            InitializeComponent();
        }

        private void yeniOgrForm_Load(object sender, EventArgs e)
        {
            cinsiyet.Items.Add("BAY");
            cinsiyet.Items.Add("BAYAN");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool cinsiyetBool;
            baglanti.Open();
            if (cinsiyet.Text == "BAY")
            {
                cinsiyetBool = true;
            }
            else
                cinsiyetBool = false;
            sorgu = new SqlCommand("insert into Kisi (isim,soyisim,cinsiyet,ogrenci,personel) values(@isim,@soyisim,@cinsiyet,1,0)",baglanti);
            sorgu.Parameters.AddWithValue("@isim",ad.Text);
            sorgu.Parameters.AddWithValue("@soyisim", soyAd.Text);
            sorgu.Parameters.AddWithValue("@cinsiyet", cinsiyetBool);
            sorgu.ExecuteNonQuery();
            MessageBox.Show("KAYIT BAŞARILI !", "KAYIT");
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
