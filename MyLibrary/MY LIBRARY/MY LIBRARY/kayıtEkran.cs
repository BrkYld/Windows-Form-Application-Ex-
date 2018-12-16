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
   
    public partial class kayıtEkran : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2QO10U0;Initial Catalog=MyLibrary;Persist Security Info=True;User ID=sa;Password=123369");
        SqlCommand sorgu;
        SqlDataReader dr;
        public kayıtEkran()
        {
            InitializeComponent();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            yayınEkle form = new yayınEkle();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kisiEkle form = new kisiEkle();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yazar_Ekle form = new yazar_Ekle();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            türEkle form = new türEkle();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitapEkle form = new kitapEkle();
            form.ShowDialog();
        }
    }
}
