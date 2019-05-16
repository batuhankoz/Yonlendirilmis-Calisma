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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlserver = new SqlConnection("Data Source=HPCOMPUTER\\SQLEXPRESS;Initial Catalog=projedatabase;Integrated Security=True");
        SqlDataAdapter sqldataadapter;
        SqlCommand sqlcommand;
        SqlDataReader sqlreader;

        private void Btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtbox_kullaniciad.MaxLength = 15;
            txtbox_sifre.MaxLength = 15;
        }

        private void Txtbox_sifre_TextChanged(object sender, EventArgs e)
        {
            int ksifre_txtuzunluk = txtbox_sifre.TextLength;
            if (ksifre_txtuzunluk == 15)
            {
                MessageBox.Show("Maksimum 15 karakter girebilirsiniz.(Şifre)");
            }
        }

        private void Txtbox_kullaniciad_TextChanged(object sender, EventArgs e)
        {
            int kad_txtuzunluk = txtbox_kullaniciad.TextLength;
            if (kad_txtuzunluk == 15)
            {
                MessageBox.Show("Maksimum 15 karakter girebilirsiniz.(Kullanici adı)");
            }
        }

        private void Btn_kayitol_Click(object sender, EventArgs e)
        {
            if (txtbox_kullaniciad.TextLength == 0 || txtbox_sifre.TextLength == 0){
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilemez");
                txtbox_kullaniciad.Clear();
                txtbox_sifre.Clear();
            }
            else
            {
                sqlserver.Open();
                string kontrolsorgu = "select * from tbl_kullanici where kullanici_ad ='"+txtbox_kullaniciad.Text+"'";
                sqlcommand = new SqlCommand(kontrolsorgu, sqlserver);
                sqlreader = sqlcommand.ExecuteReader();
                if (sqlreader.Read())
                {
                    sqlserver.Close();
                    sqlreader.Close();
                    MessageBox.Show("Kullanıcı adı zaten kullanımda.");
                    txtbox_kullaniciad.Clear();
                    txtbox_sifre.Clear();
                }
                else
                {
                    sqlreader.Close();
                    string eklesorgu = "INSERT INTO tbl_kullanici(kullanici_ad,kullanici_sifre) VALUES (@kullanici_ad,@kullanici_sifre)";
                    sqlcommand = new SqlCommand(eklesorgu, sqlserver);
                    sqlcommand.Parameters.AddWithValue("@kullanici_ad", txtbox_kullaniciad.Text);
                    sqlcommand.Parameters.AddWithValue("@kullanici_sifre", txtbox_sifre.Text);
                    sqlcommand.ExecuteNonQuery();
                    sqlserver.Close();
                    MessageBox.Show("Kayıt Başarılı");
                    txtbox_kullaniciad.Clear();
                    txtbox_sifre.Clear();
                }
            }
        }
    }
}
