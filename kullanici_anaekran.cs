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

namespace Batu
{
    public partial class kullanici_anaekran : Form
    {
        public kullanici_anaekran()
        {
            InitializeComponent();
        }
        string k_ad = Form3.k_ad;
        SqlConnection sqlserver = new SqlConnection("Data Source=HPCOMPUTER\\SQLEXPRESS;Initial Catalog=projedatabase;Integrated Security=True");
        SqlDataAdapter sqldataadapter;
        SqlCommand sqlcommand;
        SqlDataReader sqlreader;
        private void Form5_Load(object sender, EventArgs e)
        {
            // Console.Write(k_ad);
            //lbl_kullaniciad.Visible = false;
            //lbl_kullanicipuan.Visible = false;
            sqlserver.Open();
            sqlcommand = new SqlCommand("Select kullanici_puan from tbl_kullanici Where kullanici_ad = '"+k_ad+"'",sqlserver);
            sqlreader = sqlcommand.ExecuteReader();
            //  lbl_kullaniciad.Text = k_ad;
            // lbl_kullanicipuan.Text =sqlreader["kullanici_puan"].ToString();
            if (sqlreader.Read())
            {
                lbl_kullaniciad.Text = k_ad;
                lbl_kullanicipuan.Text = sqlreader["kullanici_puan"].ToString();
                sqlserver.Close();
            }
            else
            {
                lbl_kullaniciad.Text = "Veri çekilemedi";
                lbl_kullanicipuan.Text= "Veri çekilemedi";
                sqlserver.Close();
            }
        }

        private void Btn_oyna_Click(object sender, EventArgs e)
        {
            kullanicioyna_ekran normkullanici_oynaekrani = new kullanicioyna_ekran();
            normkullanici_oynaekrani.ShowDialog();
        }

        private void Lbl_cikisyap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_yenile_Click(object sender, EventArgs e)
        {
            sqlserver.Open();
            sqlcommand = new SqlCommand("Select kullanici_puan from tbl_kullanici Where kullanici_ad = '" + k_ad + "'", sqlserver);
            sqlreader = sqlcommand.ExecuteReader();
            if (sqlreader.Read())
            {
                lbl_kullaniciad.Text = k_ad;
                lbl_kullanicipuan.Text = sqlreader["kullanici_puan"].ToString();
                sqlserver.Close();
            }
            else
            {
                lbl_kullaniciad.Text = "Veri çekilemedi";
                lbl_kullanicipuan.Text = "Veri çekilemedi";
                sqlserver.Close();
            }
        }

        private void Btn_hakkimizda_Click(object sender, EventArgs e)
        {
            hakkimizda_ekran hakkimizdaekrani = new hakkimizda_ekran();
            hakkimizdaekrani.Show();
        }

        private void Btn_hakkimizda_Click_1(object sender, EventArgs e)
        {
            hakkimizda_ekran hakkimizdaekrani = new hakkimizda_ekran();
            hakkimizdaekrani.Show();
        }

        private void Btn_siralama_Click(object sender, EventArgs e)
        {
            kullanicisiralama_ekran siralamaekrani = new kullanicisiralama_ekran();
            siralamaekrani.Show();
        }
    }
}
