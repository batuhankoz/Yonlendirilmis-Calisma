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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public static string k_ad = Form3.k_ad;
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
            }
            else
            {
                lbl_kullaniciad.Text = "veri cekilemedi";
                lbl_kullanicipuan.Text= "veri cekilemedi";
            }
        }

        private void Btn_oyna_Click(object sender, EventArgs e)
        {
            Form6 oynaekrani = new Form6();
            oynaekrani.ShowDialog();
        }
    }
}
