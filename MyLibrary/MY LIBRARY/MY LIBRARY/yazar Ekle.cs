﻿using System;
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
    public partial class yazar_Ekle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2QO10U0;Initial Catalog=MyLibrary;Persist Security Info=True;User ID=sa;Password=123369");
        SqlCommand sorgu;
        SqlDataReader dr;
        public yazar_Ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            sorgu = new SqlCommand("insert into Yazar (yazarAd,yazarSoyad) values (@ad,@soyad)",baglanti);
            sorgu.Parameters.AddWithValue("@ad", textBox1.Text);
            sorgu.Parameters.AddWithValue("@soyad", textBox2.Text);
            sorgu.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("KAYIT BAŞARILI !", "KAYIT");

            this.Close();
        }
    }
}
