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
    public partial class kitapEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2QO10U0;Initial Catalog=MyLibrary;Persist Security Info=True;User ID=sa;Password=123369");
        SqlCommand sorgu;
        SqlDataReader dr;
        String yazarAd;
        public kitapEkle()
        {
            InitializeComponent();
        }

        private void kitapEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            sorgu = new SqlCommand("select*from Yazar",baglanti);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                yazar.Items.Add(dr["yazarAD"].ToString() + " " + dr["yazarSoyad"].ToString());
            }
            dr.Close();
            sorgu = new SqlCommand("select*from Tür", baglanti);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                tür.Items.Add(dr["turAdi"].ToString());
            }
            dr.Close();
            sorgu = new SqlCommand("select*from Dil", baglanti);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                dil.Items.Add(dr["dil"].ToString() );
            }
            dr.Close();
            sorgu = new SqlCommand("select*from YayınEvi", baglanti);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                yayın.Items.Add(dr["yayınEvi"].ToString());
            }
            dr.Close();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yazarAd = yazar.Text;
            string[] yazarTüm = yazarAd.Split(' ');
            string yazarID = "";
            string turID = "";
            string dilID = "";
            string yayınID = "";
            baglanti.Open();
            sorgu = new SqlCommand("select yazarID from Yazar where yazarAd = @AD and yazarSoyad = @SOYAD ",baglanti);
            sorgu.Parameters.AddWithValue("@AD", yazarTüm[0]);
            sorgu.Parameters.AddWithValue("@SOYAD", yazarTüm[1]);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                yazarID = dr["yazarID"].ToString();
            }
            dr.Close();
            sorgu = new SqlCommand("select turID from Tür where turAdi = @AD ",baglanti);
            sorgu.Parameters.AddWithValue("@AD", tür.Text);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                turID = dr["turID"].ToString();
            }
            dr.Close();
            sorgu = new SqlCommand("select dilID from Dil where dil = @AD ", baglanti);
            sorgu.Parameters.AddWithValue("@AD", dil.Text);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                dilID = dr["dilID"].ToString();
            }
            dr.Close();
            sorgu = new SqlCommand("select yayınID from YayınEvi where yayınEvi = @AD ", baglanti);
            sorgu.Parameters.AddWithValue("@AD", yayın.Text);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                yayınID = dr["yayınID"].ToString();
            }
            dr.Close();

            sorgu = new SqlCommand("insert into Kitap(kitapAdi,yazarID,turID,sayfaSayisi,dilID,yayınID) values (@ad,@yazar,@tur,@sayfa,@dil,@yayın)", baglanti);
            sorgu.Parameters.AddWithValue("@ad", kitapAd.Text);
            sorgu.Parameters.AddWithValue("@yazar", yazarID);
            sorgu.Parameters.AddWithValue("@tur", turID);
            sorgu.Parameters.AddWithValue("@sayfa", sayfaSayi.Text);
            sorgu.Parameters.AddWithValue("@dil", dilID);
            sorgu.Parameters.AddWithValue("@yayın", yayınID );
            sorgu.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("KAYIT BAŞARILI !", "KAYIT");

            this.Close();


        }
    }
}
