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
    public partial class z5_m2 : Form
    {
        public z5_m2()
        {
            InitializeComponent();
        }
        int saniye = 0;
        int dakika = 2;
        int puan = 120;
        string k_ad = Form3.k_ad;
        SqlConnection sqlserver = new SqlConnection("Data Source=HPCOMPUTER\\SQLEXPRESS;Initial Catalog=projedatabase;Integrated Security=True");
        SqlDataAdapter sqldataadapter;
        SqlCommand sqlcommand;
        SqlDataReader sqlreader;
        private void Z5_m2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bu bölümün süresi :" + dakika + "dakika : " + saniye + "saniye'dir.Anahtarı bulup gizli kapıyı açın !");
            Point baslangicnoktasi = new Point(315, 40);
            Cursor.Position = PointToScreen(baslangicnoktasi);
            sure.Enabled = true;
            sure.Interval = 1000;
            sure.Start();
        }
        private void Duvara_dokundu(object sender, EventArgs e)
        {
            MessageBox.Show("Duvara değdin ve başlangıç noktasına dönüyorsun.Bi'daha ki sefere daha dikkatli olmalısın.");
            Point baslangicnoktasi = new Point(315, 40);
            Cursor.Position = PointToScreen(baslangicnoktasi);
        }
        private void Bitis(object sender, EventArgs e)
        {
            sure.Stop();
            MessageBox.Show("Tebrikler haritayı bitirdiniz...(Kazanılan puan: " + puan + ")");
            sqlserver.Open();
            sqlcommand = new SqlCommand("UPDATE tbl_kullanici SET kullanici_puan=kullanici_puan+'" + puan + "' WHERE kullanici_ad = '" + k_ad + "'", sqlserver);
            sqlcommand.ExecuteNonQuery();
            sqlserver.Close();
            this.Close();
        }
        private void esc_tusu(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                sure.Stop();
                Close();
            }
        }
        private void anahtar(object sender, EventArgs e)
        {
            anahtar_sure.Enabled = true;
            anahtar_sure.Interval = 800;
            anahtar_sure.Start();
        }
        private void Anahtar_sure_Tick_1(object sender, EventArgs e)
        {
            if (pictureBox46.Visible == false)
            {
                pictureBox46.Visible = true;
            }
            else
            {
                pictureBox46.Visible = false;
            }
        }
    }
}