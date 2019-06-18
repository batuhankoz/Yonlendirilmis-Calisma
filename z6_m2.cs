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
    public partial class z6_m2 : Form
    {
        public z6_m2()
        {
            InitializeComponent();
        }
        int saniye = 15;
        int dakika = 2;
        double puan = 135;
        string k_ad = Form3.k_ad;
        SqlConnection sqlserver = new SqlConnection("Data Source=HPCOMPUTER\\SQLEXPRESS;Initial Catalog=projedatabase;Integrated Security=True");
        SqlDataAdapter sqldataadapter;
        SqlCommand sqlcommand;
        SqlDataReader sqlreader;
        private void Sure_Tick(object sender, EventArgs e)
        {
            if (dakika != 0)
            {
                saniye = saniye - 1;
                puan = puan - 1;
                if (saniye <= 0)
                {
                    saniye = 59;
                    dakika = dakika - 1;
                }
            }
            else if (dakika == 0)
            {
                if (saniye != 0)
                {
                    saniye = saniye - 1;
                    puan = puan - 1;
                }
                else
                {
                    sure.Stop();
                    MessageBox.Show("Belirtilen süre içinde oyunu bitiremedin..Üzülme bi'daha ki sefere daha iyi hazırlan :)");
                    this.Close();
                }
            }
            lbl_sure.Text = "Dakika: " + dakika + "Saniye: " + saniye;
            if (pictureBox33.Visible == false)
            {
                pictureBox33.Visible = true;
            }
            else
            {
                pictureBox33.Visible = false;
            }
            if (pictureBox60.Visible == false)
            {
                pictureBox60.Visible = true;
            }
            else
            {
                pictureBox60.Visible = false;
            }
            if (pictureBox19.Visible == false)
            {
                pictureBox19.Visible = true;
            }
            else
            {
                pictureBox19.Visible = false;
            }
        }

        private void Anahtar_sure_Tick(object sender, EventArgs e)
        {

            if (pictureBox41.Visible == false)
            {
                pictureBox41.Visible = true;
            }
            else
            {
                pictureBox41.Visible = false;
            }
        }

        private void Duvara_dokundu(object sender, EventArgs e)
        {
            MessageBox.Show("Duvara değdin ve başlangıç noktasına dönüyorsun.Bi'daha ki sefere daha dikkatli olmalısın.");
            Point baslangicnoktasi = label1.Location;
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
            MessageBox.Show("Doğru anahtarı buldun ! Gizli kapı açıldı.");
            anahtar_sure.Enabled = true;
            anahtar_sure.Interval = 700;
            anahtar_sure.Start();
        }

        private void yanlis_anahtar(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış anahtarı seçtin.Diğerlerini dene :)");
        }

        private void Z6_m2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bu bölümün süresi :" + dakika + "dakika : " + saniye + "saniye'dir.Anahtarı bulup gizli kapıyı açın ve gizli tuzaklara dikkat edin !");
            Point baslangicnoktasi = label1.Location;
            Cursor.Position = PointToScreen(baslangicnoktasi);
            sure.Enabled = true;
            sure.Interval = 1000;
            sure.Start();
        }
    }
}
