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
    public partial class türEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2QO10U0;Initial Catalog=MyLibrary;Persist Security Info=True;User ID=sa;Password=123369");
        SqlCommand sorgu;
        SqlDataReader dr;
        public türEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            sorgu = new SqlCommand("insert into Tür(turAdi) values (@turAd)", baglanti);
            sorgu.Parameters.AddWithValue("@turAd", textBox1.Text);
            sorgu.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("KAYIT BAŞARILI !", "KAYIT");

            this.Close();
        }

        private void türEkle_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
