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
    public partial class kisiEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2QO10U0;Initial Catalog=MyLibrary;Persist Security Info=True;User ID=sa;Password=123369");
        SqlCommand sorgu;
        SqlDataReader dr;
        bool ogrenciMi;
        bool personelMi;
        bool cinsiyetBool;
        public kisiEkle()
        {
            InitializeComponent();
        }

        private void kisiEkle_Load(object sender, EventArgs e)
        {
            cinsiyet.Items.Add("BAY");
            cinsiyet.Items.Add("BAYAN");
            yetki.Items.Add("PERSONEL");
            yetki.Items.Add("ÖĞRENCİ");
            yetki.Text = "ÖĞRENCİ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cinsiyet.Text == "BAY")
            {
                cinsiyetBool = true;
            }
            else
            {
                cinsiyetBool = false;
            }
            if(yetki.Text == "PERSONEL")
            {
                personelMi = true;
                ogrenciMi = false;
            }
            else
            {
                personelMi = false;
                ogrenciMi = true;
            }
            baglanti.Open();
            sorgu = new SqlCommand("insert into Kisi(isim,soyisim,cinsiyet,personel,ogrenci) values(@isim,@soyisim,@cinsiyet,@personel,@ogrenci)", baglanti);
            sorgu.Parameters.AddWithValue("@isim", isim.Text);
            sorgu.Parameters.AddWithValue("@soyisim", soyisim.Text);
            sorgu.Parameters.AddWithValue("@cinsiyet", cinsiyetBool);
            sorgu.Parameters.AddWithValue("@personel", personelMi);
            sorgu.Parameters.AddWithValue("@ogrenci", ogrenciMi);
            sorgu.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("KAYIT BAŞARILI !" , "KAYIT");

            this.Close();

        }
    }
}
