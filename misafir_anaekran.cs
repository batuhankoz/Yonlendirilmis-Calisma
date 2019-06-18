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
    public partial class misafir_anaekran : Form
    {
        public misafir_anaekran()
        {
            InitializeComponent();
        }

        private void Btn_kayitol_Click(object sender, EventArgs e)
        {
            //Form1 ilksayfa = new Form1();
            //ilksayfa.Hide();
            kayit_ekran kayitolekrani = new kayit_ekran();
            kayitolekrani.Show();
        }

        private void Btn_girisyap_Click(object sender, EventArgs e)
        {
            //Form1 ilksayfa = new Form1();
            // .Hide();
            //Program.ilk_sayfa.Enabled = false;
            Form3 girisyapekrani = new Form3();
            girisyapekrani.Show();   
        }

        private void Btn_oyna_Click(object sender, EventArgs e)
        {
            misafiroyna_ekran oynaekrani_unlogin = new misafiroyna_ekran();
            oynaekrani_unlogin.ShowDialog();
        }

        private void Btn_hakkimizda_Click(object sender, EventArgs e)
        {
            hakkimizda_ekran hakkimizdaekrani = new hakkimizda_ekran();
            hakkimizdaekrani.Show();
        }

        private void Btn_siralama_Click(object sender, EventArgs e)
        {
            siralama_ekrani siralamaekran = new siralama_ekrani();
            siralamaekran.Show();
        }
    }
}