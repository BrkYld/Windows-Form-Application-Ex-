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
    public partial class islemKayıt : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2QO10U0;Initial Catalog=MyLibrary;Persist Security Info=True;User ID=sa;Password=123369");
        SqlCommand sorgu;
        SqlDataReader dr;
        public islemKayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string ogr = comboBox1.Text;
            string ogrID = "";
            string kitapID = "";
            string[] ogrTüm = ogr.Split(' ');
            sorgu = new SqlCommand("select kisiID from Kisi where isim = @ad and soyisim = @soyad ", baglanti);
            sorgu.Parameters.AddWithValue("@ad",ogrTüm[0]);
            sorgu.Parameters.AddWithValue("@soyad", ogrTüm[1]);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                ogrID = dr["kisiID"].ToString();
            }
            dr.Close();

            sorgu = new SqlCommand("select kitapID from Kitap where kitapAdi = @ad ", baglanti);
            sorgu.Parameters.AddWithValue("@ad", comboBox2.Text);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                kitapID = dr["kitapID"].ToString();
            }
            dr.Close();

            sorgu = new SqlCommand("insert into İşlem (kisiID,kitapID,iadeTarih) values (@kisiID,@kitapID,@iade)", baglanti);
            sorgu.Parameters.AddWithValue("@kisiID", ogrID);
            sorgu.Parameters.AddWithValue("@kitapID",kitapID);
            sorgu.Parameters.AddWithValue("@iade", dateTimePicker1.Value);
            sorgu.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("KAYIT BAŞARILI !! "," KAYIT ");
            this.Close();

        }
        private void islemKayıt_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            sorgu = new SqlCommand("select*from Kisi where ogrenci = 1", baglanti);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["isim"].ToString() + " " + dr["soyisim"].ToString());
            }
            dr.Close();
            sorgu = new SqlCommand("select*from Kitap", baglanti);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["kitapAdi"].ToString());
            }
            dr.Close();
           
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
