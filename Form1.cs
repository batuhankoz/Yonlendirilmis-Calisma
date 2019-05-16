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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_kayitol_Click(object sender, EventArgs e)
        {
            //Form1 ilksayfa = new Form1();
            //ilksayfa.Hide();
            Form2 kayitolekrani = new Form2();
            kayitolekrani.Show();
        }

        private void Btn_girisyap_Click(object sender, EventArgs e)
        {
           //Form1 ilksayfa = new Form1();
           //ilksayfa.Hide();
            Form3 girisyapekrani = new Form3();
            girisyapekrani.Show();
        }

        private void Btn_oyna_Click(object sender, EventArgs e)
        {
            Form4 oynaekrani = new Form4();
            oynaekrani.ShowDialog();
        }


    }
}