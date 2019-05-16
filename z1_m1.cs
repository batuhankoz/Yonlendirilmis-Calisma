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
    public partial class z1_m1 : Form
    {
        public z1_m1()
        {
            InitializeComponent();
        }

        private void Duvara_dokundu(object sender, EventArgs e)
        {
            MessageBox.Show("Duvara değdin ve başlangıç noktasına dönüyorsun.Bi'daha ki sefere daha dikkatli olmalısın.");
            Point baslangicnoktasi = label1.Location;
            Cursor.Position = PointToScreen(baslangicnoktasi);
        }

        private void Bitis(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler bitirdiniz...");
        }

        private void esc_tusu(object sender, KeyPressEventArgs e)
        {
            Close();
        }


    }
}
