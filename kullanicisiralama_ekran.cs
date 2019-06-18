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
    public partial class kullanicisiralama_ekran : Form
    {
        public kullanicisiralama_ekran()
        {
            InitializeComponent();
        }
        string k_ad = Form3.k_ad;
        SqlConnection sqlserver = new SqlConnection("Data Source=HPCOMPUTER\\SQLEXPRESS;Initial Catalog=projedatabase;Integrated Security=True");
        SqlDataAdapter sqldataadapter;
        SqlCommand sqlcommand;
        SqlDataReader sqlreader;
        private void Btn_yenile_Click(object sender, EventArgs e)
        {
            sqlserver.Open();
            sqlcommand = new SqlCommand("Select kullanici_puan from tbl_kullanici Where kullanici_ad = '" + k_ad + "'", sqlserver);
            sqlreader = sqlcommand.ExecuteReader();

            if (sqlreader.Read())
            {
                lbl_kullaniciad.Text = k_ad;
                lbl_kullanicipuan.Text = sqlreader["kullanici_puan"].ToString();
            }
            else
            {
                lbl_kullaniciad.Text = "Veri çekilemedi";
                lbl_kullanicipuan.Text = "Veri çekilemedi";
            }
            sqlreader.Close();
            listView1.Items.Clear();
            sqlcommand = new SqlCommand("SELECT kullanici_ad,kullanici_puan FROM tbl_kullanici WHERE kullanici_ad <> 'Admin' ORDER BY kullanici_puan DESC", sqlserver);
            sqlreader = sqlcommand.ExecuteReader();
            while (sqlreader.Read())
            {
                if (sqlreader.ToString() == "Admin") {

                }
                else {
                    ListViewItem list_item = new ListViewItem(sqlreader["kullanici_ad"].ToString());
                    list_item.SubItems.Add(sqlreader["kullanici_puan"].ToString());
                    listView1.Items.Add(list_item);
                }
            }
            sqlserver.Close();
        }

        private void Siralama_ekran_Load(object sender, EventArgs e)
        {
            sqlserver.Open();
            sqlcommand = new SqlCommand("Select kullanici_puan from tbl_kullanici Where kullanici_ad = '" + k_ad + "'", sqlserver);
            sqlreader = sqlcommand.ExecuteReader();

            if (sqlreader.Read())
            {
                lbl_kullaniciad.Text = k_ad;
                lbl_kullanicipuan.Text = sqlreader["kullanici_puan"].ToString();
            }
            else
            {
                lbl_kullaniciad.Text = "Veri çekilemedi";
                lbl_kullanicipuan.Text = "Veri çekilemedi";
            }
            sqlreader.Close();
            listView1.Items.Clear();
            sqlcommand = new SqlCommand("SELECT kullanici_ad,kullanici_puan FROM tbl_kullanici WHERE kullanici_ad <> 'Admin' ORDER BY kullanici_puan DESC", sqlserver);
            sqlreader = sqlcommand.ExecuteReader();
            while (sqlreader.Read()) {
                ListViewItem list_item = new ListViewItem(sqlreader["kullanici_ad"].ToString());
                list_item.SubItems.Add(sqlreader["kullanici_puan"].ToString());
                listView1.Items.Add(list_item);
            }
            sqlserver.Close();
        }

        private void Btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }