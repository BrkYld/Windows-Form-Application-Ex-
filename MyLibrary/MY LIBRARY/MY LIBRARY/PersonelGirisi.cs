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
    public partial class PersonelGirisi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2QO10U0;Initial Catalog=MyLibrary;Persist Security Info=True;User ID=sa;Password=123369");
        SqlCommand sorgu;
        SqlDataReader dr;
        
        public PersonelGirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String psswrd = sifre.Text;
            String usrName = kullaniciAdi.Text;
            baglanti.Open();
            sorgu = new SqlCommand("select * from Personel",baglanti);
            dr = sorgu.ExecuteReader();
     
            while (dr.Read())
            {
               
                if(dr["kullaniciAdı"].ToString() == usrName)
                {
                    if(dr["sifre"].ToString() == psswrd)
                    {
                        PersonelEkranı form = new PersonelEkranı();
                        form.userName = usrName;
                        form.Show();
                        
                        this.Hide();
                       
                        form.FormClosing += form_FormClosing;
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
               // str = str + dr["isim"].ToString() + Environment.NewLine;
            }
           
            dr.Close();
            baglanti.Close();
        }

        private void PersonelGirisi_Load(object sender, EventArgs e)
        {
            this.Text = "PERSONEL GİRİŞİ";
        }

        void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
