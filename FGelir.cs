﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabaniUygulamasi
{
    public partial class FGelir : Form
    {

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Dukkan; userID=postgres;" +
            " password=123321a;");

        public FGelir()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            baglanti.Open();
            string sorgu = "select * from \"Gelir\" order by \"Tarih\" desc";
            NpgsqlDataAdapter da= new NpgsqlDataAdapter(sorgu,baglanti);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            baglanti.Close();
        }
        
        private void FGelir_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
