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
    public partial class kullanicioyna_ekran : Form
    {
        public kullanicioyna_ekran()
        {
            InitializeComponent();
        }
        string k_ad = Form3.k_ad;
        SqlConnection sqlserver = new SqlConnection("Data Source=HPCOMPUTER\\SQLEXPRESS;Initial Catalog=projedatabase;Integrated Security=True");
        SqlDataAdapter sqldataadapter;
        SqlCommand sqlcommand;
        SqlDataReader sqlreader;
        public static Random random = new Random();
        private void Btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
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
            if (rdbtn_1.Checked == true)
            {

                z1_m1 map1 = new z1_m1();
                z1_m2 map2 = new z1_m2();
                z1_m3 map3 = new z1_m3();
                string[] harita_listesi = { "map1", "map2", "map3" };
                int randsayi = random.Next(0, harita_listesi.Length);
                if (randsayi == 0)
                {
                    map1.ShowDialog();
                }
                else if (randsayi == 1)
                {
                    map2.ShowDialog();
                }
                else if (randsayi == 2)
                {
                    map3.ShowDialog();
                }
            }
            else if (rdbtn_2.Checked == true)
            {
                z2_m1 map1 = new z2_m1();
                z2_m2 map2 = new z2_m2();
                z2_m3 map3 = new z2_m3();
                string[] harita_listesi = { "map1", "map2", "map3" };
                int randsayi = random.Next(0, harita_listesi.Length);
                if (randsayi == 0)
                {
                    map1.ShowDialog();
                }
                else if (randsayi == 1)
                {
                    map2.ShowDialog();
                }
                else if (randsayi == 2)
                {
                    map3.ShowDialog();
                }
            }
            else if (rdbtn_3.Checked == true)
            {
                z3_m1 map1 = new z3_m1();
                z3_m2 map2 = new z3_m2();
                z3_m3 map3 = new z3_m3();
                string[] harita_listesi = { "map1", "map2", "map3" };
                int randsayi = random.Next(0, harita_listesi.Length);
                if (randsayi == 0)
                {
                    map1.ShowDialog();
                }
                else if (randsayi == 1)
                {
                    map2.ShowDialog();
                }
                else if (randsayi == 2)
                {
                    map3.ShowDialog();
                }
            }
            else if (rdbtn_4.Checked == true)
            {
                z4_m1 map1 = new z4_m1();
                z4_m2 map2 = new z4_m2();
                z4_m3 map3 = new z4_m3();
                string[] harita_listesi = { "map1", "map2", "map3" };
                int randsayi = random.Next(0, harita_listesi.Length);
                if (randsayi == 0)
                {
                    map1.ShowDialog();
                }
                else if (randsayi == 1)
                {
                    map2.ShowDialog();
                }
                else if (randsayi == 2)
                {
                    map3.ShowDialog();
                }
            }
            else if (rdbtn_5.Checked == true)
            {
                z5_m1 map1 = new z5_m1();
                z5_m2 map2 = new z5_m2();
                z5_m3 map3 = new z5_m3();
                string[] harita_listesi = { "map1", "map2", "map3" };
                int randsayi = random.Next(0, harita_listesi.Length);
                if (randsayi == 0)
                {
                    map1.ShowDialog();
                }
                else if (randsayi == 1)
                {
                    map2.ShowDialog();
                }
                else if (randsayi == 2)
                {
                    map3.ShowDialog();
                }
            }
            else if (rdbtn_6.Checked == true)
            {
                z6_m1 map1 = new z6_m1();
                z6_m2 map2 = new z6_m2();
                //z6_m3 map3 = new z6_m3();
                string[] harita_listesi = { "map1", "map2", "map3" };
                int randsayi = random.Next(0, harita_listesi.Length);
                if (randsayi == 0)
                {
                    map1.ShowDialog();
                }
                else if (randsayi == 1)
                {
                    map2.ShowDialog();
                }
                //else if (randsayi == 2)
                //{
                //    map3.ShowDialog();
                //}
            }
            else
            {
                MessageBox.Show("Lütfen bir zorluk seçiniz...");
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
    }
}