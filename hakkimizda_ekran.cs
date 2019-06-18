using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batu
{
    public partial class hakkimizda_ekran : Form
    {
        public hakkimizda_ekran()
        {
            InitializeComponent();
        }

        private void Btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hakkimizda_ekran_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            label1.Text = "2019 yılında 'En stabil ve En güvenilir oyun olma' ilkesiyle yola çıktığımız MAZE,\n" +
                " geçen 2 aylık süreçte Dünya ve Türkiye’de, en büyük labirent oyunlarından biri olmayı başarmıştır.\n" +
                "1 kişilik ekibi ile 5 / 10 destek operasyonunu sürdüren ve sürekli kendimizi geliştiren yapımız sayesinde \n" +
                "emeklerinizi korurken aynı zamanda oyun deneyiminizi sürekli olarak iyileştiriyoruz.\n\n\n"+
                "Maze olarak çıktığımız bu yolda bizimle çalışan , bize yön gösteren ve hatalarımızı görmemizi sağlayan \n"+
                "gerek değerli hocalarımız gerek siz değerli kullanıcılarımıza sonsuz teşekkürü borç biliriz.\n\n\n"+
                "Herkese iyi oyunlar dileriz.\n\n\n"+
                "Maze CEO\n" +
                "Batuhan Köz."

                
                
                ;
        }
    }
}
