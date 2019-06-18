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
    public partial class siralama_ekrani : Form
    {
        public siralama_ekrani()
        {
            InitializeComponent();
        }
        SqlConnection sqlserver = new SqlConnection("Data Source=HPCOMPUTER\\SQLEXPRESS;Initial Catalog=projedatabase;Integrated Security=True");
        SqlDataAdapter sqldataadapter;
        SqlCommand sqlcommand;
        SqlDataReader sqlreader;
        private void Siralama_ekrani_Load(object sender, EventArgs e)
        {
            sqlserver.Open();
            listView1.Items.Clear();
            sqlcommand = new SqlCommand("SELECT kullanici_ad,kullanici_puan FROM tbl_kullanici WHERE kullanici_ad <> 'Admin' ORDER BY kullanici_puan DESC", sqlserver);
            sqlreader = sqlcommand.ExecuteReader();
            while (sqlreader.Read())
            {
                if (sqlreader.ToString() == "Admin")
                {

                }
                else
                {
                    ListViewItem list_item = new ListViewItem(sqlreader["kullanici_ad"].ToString());
                    list_item.SubItems.Add(sqlreader["kullanici_puan"].ToString());
                    listView1.Items.Add(list_item);
                }
            }
            sqlserver.Close();
        }

        private void Btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_yenile_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            sqlcommand = new SqlCommand("SELECT kullanici_ad,kullanici_puan FROM tbl_kullanici WHERE kullanici_ad <> 'Admin' ORDER BY kullanici_puan DESC", sqlserver);
            sqlreader = sqlcommand.ExecuteReader();
            while (sqlreader.Read())
            {
                ListViewItem list_item = new ListViewItem(sqlreader["kullanici_ad"].ToString());
                list_item.SubItems.Add(sqlreader["kullanici_puan"].ToString());
                listView1.Items.Add(list_item);
            }
        }
    }
}
