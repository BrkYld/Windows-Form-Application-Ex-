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
    public partial class PersonelEkranı : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2QO10U0;Initial Catalog=MyLibrary;Persist Security Info=True;User ID=sa;Password=123369");
        SqlCommand sorgu;
        SqlDataReader dr;
        public String userName { get; set; }

        public PersonelEkranı()
        {

            InitializeComponent();
           
           
            
        }

        private void veriGetir()
        {
            baglanti.Open();
            sorgu = new SqlCommand("declare @id int select @id = kisiID from Personel where kullaniciAdı = @ussrname select isim , soyisim from Kisi where kisiID = @id", baglanti);
            sorgu.Parameters.AddWithValue("@ussrname", userName);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {
                isim.Text = dr["isim"].ToString();
                soyisim.Text = dr["soyisim"].ToString();
            }

            dr.Close();
            baglanti.Close();
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
            islemPanel.Visible = true;
            sorgu = new SqlCommand("select * from İşlem",baglanti);
            dr = sorgu.ExecuteReader();
            while (dr.Read())
            {

                kisiID.Add(dr["kisiID"].ToString());
                kitapID.Add(dr["kitapID"].ToString());
                alimTarih.Add(dr["alimTarih"].ToString());
                iadeTarih.Add(dr["iadeTarih"].ToString());

            }
            dr.Close();
           
            foreach(string id in kitapID)
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
            
            foreach(string id in kisiID)
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
            
            for(int i = 0; i < isim.Count; i++)
            {
                satir = satir +(i+1).ToString()+ "-  " + kitapAdi[i] + "  =>  " + isim[i] + "  " + soyisim[i] + "  " + alimTarih[i] + "  -->  " + iadeTarih[i] + Environment.NewLine + Environment.NewLine;
            }
           
            
            baglanti.Close();
            label2.Text = satir;
        }

        private void PersonelEkranı_Load(object sender, EventArgs e)
        {
            
            veriGetir();
            islemGetir();
            

        }

        private void islem_Click(object sender, EventArgs e)
        {
            islemForm form = new islemForm();
            form.ShowDialog();
        }

        private void sifreDegis_Click(object sender, EventArgs e)
        {
            sifreDegis form = new sifreDegis();
            form.userNamee = userName;
            form.ShowDialog();

        }

        private void kayit_Click(object sender, EventArgs e)
        {
            kayıtEkran form = new kayıtEkran();
            form.ShowDialog();
        }

        private void islemPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Çıkış_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

       


