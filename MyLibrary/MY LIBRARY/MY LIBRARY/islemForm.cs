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
using System.Collections;
namespace MY_LIBRARY
{
    public partial class islemForm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2QO10U0;Initial Catalog=MyLibrary;Persist Security Info=True;User ID=sa;Password=123369");
        SqlCommand sorgu;
        SqlDataReader dr;
        public islemForm()
        {
            InitializeComponent();
        }
        private void ogrGetir()
        {
            string satir = "";
            baglanti.Open();
            sorgu = new SqlCommand("select isim , soyisim from Kisi where ogrenci = 1", baglanti);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                satir = satir + dr["isim"].ToString() + "  " + dr["soyisim"].ToString() + Environment.NewLine +Environment.NewLine;
            }
            ogrenci.Text = satir;
            dr.Close();
            baglanti.Close();
        }
        private void kitapGetir()
        {
            string satir = "";
            List<string> turID = new List<string>();
            List<string> turAd = new List<string>();
            List<string> yazarID = new List<string>();
            List<string> yazarAd = new List<string>();
            List<string> dilID = new List<string>();
            List<string> dilAd = new List<string>();
            List<string> yayınID = new List<string>();
            List<string> yayınAd = new List<string>();
            List<string> kitapAdi = new List<string>();
            List<string> stok = new List<string>();
            baglanti.Open();
            sorgu = new SqlCommand("select*from Kitap", baglanti);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                turID.Add(dr["turID"].ToString());
                yazarID.Add(dr["yazarID"].ToString());
                dilID.Add(dr["dilID"].ToString());
                yayınID.Add(dr["yayınID"].ToString());
                kitapAdi.Add(dr["kitapAdi"].ToString());
                stok.Add(dr["stok"].ToString());
            }
            dr.Close();
           
            foreach(string id in turID)
            {
                sorgu = new SqlCommand("select turAdi from Tür where turID = @ID", baglanti);
                sorgu.Parameters.AddWithValue("@ID", id);
                dr = sorgu.ExecuteReader();
                while (dr.Read())
                {
                    turAd.Add(dr["turAdi"].ToString());
                    
                }
                dr.Close();
            }
            
            foreach (string id in yazarID)
            {
                sorgu = new SqlCommand("select*from Yazar where yazarID = @ID", baglanti);
                sorgu.Parameters.AddWithValue("@ID", id);
                dr = sorgu.ExecuteReader();
                while (dr.Read())
                {
                    yazarAd.Add(dr["yazarAD"].ToString() + "  " + dr["yazarSoyad"].ToString());
                    
                }
                dr.Close();
            }
           
            foreach (string id in dilID)
            {
                sorgu = new SqlCommand("select*from Dil where dilID = @ID", baglanti);
                sorgu.Parameters.AddWithValue("@ID", id);
                dr = sorgu.ExecuteReader();
                while (dr.Read())
                {
                    dilAd.Add(dr["dil"].ToString()) ;
                    
                }
                dr.Close();
            }
            
            foreach (string id in yayınID)
            {
                sorgu = new SqlCommand("select*from YayınEvi where yayınID = @ID", baglanti);
                sorgu.Parameters.AddWithValue("@ID", id);
                dr = sorgu.ExecuteReader();
                while (dr.Read())
                {
                    yayınAd.Add(dr["yayınEvi"].ToString());
                    
                }
                dr.Close();
            }

            for(int i = 0; i < kitapAdi.Count; i++)
            {
                satir = satir + kitapAdi[i] + " / " + yazarAd[i] + " / " + turAd[i] + " / " + dilAd[i] + " / " + yayınAd[i] + " / " + stok[i] + " Adet"+ Environment.NewLine + Environment.NewLine;

            }
            kitaplar.Text = satir;
            baglanti.Close();


        }
        private void islemForm_Load(object sender, EventArgs e)
        {

            ogrGetir();
            kitapGetir();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yeniOgrForm form = new yeniOgrForm();
            form.ShowDialog();
            ogrGetir();
            kitapGetir();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            islemKayıt form = new islemKayıt();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            islemİade form = new islemİade();
            form.ShowDialog();
        }
    }
}
