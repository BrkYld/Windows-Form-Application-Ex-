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
    
    public partial class islemİade : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2QO10U0;Initial Catalog=MyLibrary;Persist Security Info=True;User ID=sa;Password=123369");
        SqlCommand sorgu;
        SqlDataReader dr;
        List<String> islemID = new List<String>();
        public islemİade()
        {
            InitializeComponent();
        }
        private void islemGetir()
        {
            List<String> kisiID = new List<String>();
            List<String> kitapID = new List<String>();
            List<String> alimTarih = new List<string>();
            List<String> iadeTarih = new List<string>();
            List<String> kitapAdi = new List<string>();
            List<String> isim = new List<string>();
            List<String> soyisim = new List<string>();
            String satir = "";
            baglanti.Open();
            
            sorgu = new SqlCommand("select * from İşlem", baglanti);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                islemID.Add(dr["islemID"].ToString());
                kisiID.Add(dr["kisiID"].ToString());
                kitapID.Add(dr["kitapID"].ToString());
                alimTarih.Add(dr["alimTarih"].ToString());
                iadeTarih.Add(dr["iadeTarih"].ToString());

            }
            dr.Close();

            foreach (string id in kitapID)
            {
                sorgu = new SqlCommand("select kitapAdi from Kitap where kitapID = @ID", baglanti);
                sorgu.Parameters.AddWithValue("@ID", id);
                dr = sorgu.ExecuteReader();
                while (dr.Read())
                {
                    kitapAdi.Add(dr["kitapAdi"].ToString());
                }
                dr.Close();
            }

            foreach (string id in kisiID)
            {
                sorgu = new SqlCommand("select isim,soyisim from Kisi where kisiID = @ID", baglanti);
                sorgu.Parameters.AddWithValue("@ID", id);
                dr = sorgu.ExecuteReader();
                while (dr.Read())
                {
                    isim.Add(dr["isim"].ToString());
                    soyisim.Add(dr["soyisim"].ToString());

                }
                dr.Close();
            }

            for (int i = 0; i < isim.Count; i++)
            {
                satir = satir + islemID[i] + "-  " + kitapAdi[i] + "  =>  " + isim[i] + "  " + soyisim[i] + "  " + alimTarih[i] + "  -->  " + iadeTarih[i] + Environment.NewLine + Environment.NewLine;
            }


            baglanti.Close();
            label2.Text = satir;
        }
        private void islemİade_Load(object sender, EventArgs e)
        {
            islemGetir();
            for(int i = 0; i < islemID.Count; i++)
            {
                comboBox1.Items.Add(islemID[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            sorgu = new SqlCommand("delete from İşlem where islemID = @ID",baglanti);
            sorgu.Parameters.AddWithValue("@ID",comboBox1.Text);
            sorgu.ExecuteNonQuery();
            MessageBox.Show("KİTAP İADESİ ALINDI ", "İADE");
        }
    }
}
