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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public static string k_ad = Form3.k_ad;
        SqlConnection sqlserver = new SqlConnection("Data Source=HPCOMPUTER\\SQLEXPRESS;Initial Catalog=projedatabase;Integrated Security=True");
        SqlDataAdapter sqldataadapter;
        SqlCommand sqlcommand;
        SqlDataReader sqlreader;
        private void Btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projedatabaseDataSet2.tbl_kullanici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_kullaniciTableAdapter2.Fill(this.projedatabaseDataSet2.tbl_kullanici);
            // TODO: Bu kod satırı 'projedatabaseDataSet1.tbl_kullanici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_kullaniciTableAdapter1.Fill(this.projedatabaseDataSet1.tbl_kullanici);
            // TODO: Bu kod satırı 'projedatabaseDataSet.tbl_kullanici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_kullaniciTableAdapter.Fill(this.projedatabaseDataSet.tbl_kullanici);
            sqlserver.Open();

            sqlcommand = new SqlCommand("Select kullanici_puan from tbl_kullanici Where kullanici_ad = '" + k_ad + "'", sqlserver);
            sqlreader = sqlcommand.ExecuteReader();
            //  lbl_kullaniciad.Text = k_ad;
            // lbl_kullanicipuan.Text =sqlreader["kullanici_puan"].ToString();
            if (sqlreader.Read())
            {
                lbl_kullaniciad.Text = k_ad;
                lbl_kullanicipuan.Text = sqlreader["kullanici_puan"].ToString();
            }
            else
            {
                lbl_kullaniciad.Text = "veri cekilemedi";
                lbl_kullanicipuan.Text = "veri cekilemedi";
            }
        }

        private void Btn_oyna_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (rdbtn_1.Checked == true)
            {

                z1_m1 map1 = new z1_m1();
                z1_m2 map2 = new z1_m2();
                string[] harita_listesi = { "map1", "map2" };
                Random random = new Random();
                int randsayi = random.Next(0, harita_listesi.Length);
                if (randsayi == 0)
                {
                    map1.ShowDialog();
                }
                else if (randsayi == 1)
                {
                    map2.ShowDialog();
                }
            }
            else if (rdbtn_2.Checked == true)
            {

            }
            else if (rdbtn_3.Checked == true)
            {

            }
            else if (rdbtn_4.Checked == true)
            {

            }
            else if (rdbtn_5.Checked == true)
            {

            }
            else if (rdbtn_6.Checked == true)
            {

            }
            else
            {
                MessageBox.Show("Lütfen bir zorluk seçiniz...");
                this.Show();
            }
        }
    }
}