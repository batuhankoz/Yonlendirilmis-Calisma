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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static string  k_ad;
        SqlConnection sqlserver = new SqlConnection("Data Source=HPCOMPUTER\\SQLEXPRESS;Initial Catalog=projedatabase;Integrated Security=True");
        SqlDataAdapter sqldataadapter;
        SqlCommand sqlcommand;
        SqlDataReader sqlreader;

        public bool giris(string kullanici_ad, string kullanici_sifre) {
            sqlserver.Open();
            sqlcommand = new SqlCommand("Select * from tbl_kullanici Where kullanici_ad=@kullanici_ad and kullanici_sifre=@kullanici_sifre",sqlserver);
            sqlcommand.Parameters.AddWithValue("@kullanici_ad",kullanici_ad);
            sqlcommand.Parameters.AddWithValue("@kullanici_sifre",kullanici_sifre);
            sqlreader = sqlcommand.ExecuteReader();
            if (sqlreader.Read())
            {
                sqlserver.Close();
                sqlreader.Close();
                return true;
            }
            else {
                sqlserver.Close();
                sqlreader.Close();
                return false;
            }
        }
        private void Btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            txtbox_kullaniciad.MaxLength = 15;
            txtbox_sifre.MaxLength = 15;
            k_ad = "";
        }

        private void Txtbox_kullaniciad_TextChanged(object sender, EventArgs e)
        {
            int kad_txtuzunluk = txtbox_kullaniciad.TextLength;
            if (kad_txtuzunluk == 15)
            {
                MessageBox.Show("Maksimum 15 karakter girebilirsiniz.(Kullanici adı)");
            }
        }
        private void Txtbox_sifre_TextChanged(object sender, EventArgs e)
        {
            int ksifre_txtuzunluk = txtbox_sifre.TextLength;
            if (ksifre_txtuzunluk == 15)
            {
                MessageBox.Show("Maksimum 15 karakter girebilirsiniz.(Şifre)");
            }
        }
        private void Btn_girisyap_Click_1(object sender, EventArgs e)
        {
            bool girisislemi = giris(txtbox_kullaniciad.Text, txtbox_sifre.Text);
            if (girisislemi == true)
            {
                this.Close();
                //Program.ilk_sayfa.Close();
                MessageBox.Show("Giriş başarılı");
                Program.ilk_sayfa.Visible=false;
                if (txtbox_kullaniciad.Text == "Admin" && txtbox_sifre.Text == "Admin")
                {
                    k_ad = txtbox_kullaniciad.Text;
                    //BURADA ADMİN FORMU AÇILACAK
                }
                else
                {
                    k_ad = txtbox_kullaniciad.Text;
                    kullanici_anaekran normkullanici_ilksayfa = new kullanici_anaekran();
                    normkullanici_ilksayfa.ShowDialog();
                }
                txtbox_kullaniciad.Clear();
                txtbox_sifre.Clear();
            }
            else if (girisislemi == false)
            {
                MessageBox.Show("Kullanıcı adı veya Şifre yanlış");
                txtbox_kullaniciad.Clear();
                txtbox_sifre.Clear();
            }
            else {
                MessageBox.Show("Bir hata ile karşılaştık :(. Lütfen daha sonra tekrar deneyiniz...");
            }
        }

        private void enter_tusu(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                bool girisislemi = giris(txtbox_kullaniciad.Text, txtbox_sifre.Text);
                if (girisislemi == true)
                {
                    MessageBox.Show("Giriş başarılı");
                    if (txtbox_kullaniciad.Text == "Admin" && txtbox_sifre.Text == "Admin")
                    {
                        k_ad = txtbox_kullaniciad.Text;
                        //BURADA ADMİN FORMU AÇILACAK
                    }
                    else
                    {
                        k_ad = txtbox_kullaniciad.Text;
                        this.Close();
                        kullanici_anaekran normkullanici_ilksayfa = new kullanici_anaekran();
                        normkullanici_ilksayfa.ShowDialog();
                    }
                    txtbox_kullaniciad.Clear();
                    txtbox_sifre.Clear();
                }
                else if (girisislemi == false)
                {
                    MessageBox.Show("Kullanıcı adı veya Şifre yanlış");
                    txtbox_kullaniciad.Clear();
                    txtbox_sifre.Clear();
                }
            }
        }
        private void Btn_hakkimizda_Click(object sender, EventArgs e)
        {
            hakkimizda_ekran hakkimizdaekrani = new hakkimizda_ekran();
            hakkimizdaekrani.Show();
        }
    }
}