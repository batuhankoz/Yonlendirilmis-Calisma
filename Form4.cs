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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_oyna_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (rdbtn_1.Checked == true)
            {
                
                z1_m1 map1 = new z1_m1();
                z1_m2 map2 = new z1_m2();
                string[] harita_listesi = { "map1","map2" };
                Random random = new Random();
                int  randsayi= random.Next(0, harita_listesi.Length);
                if (randsayi == 0)
                {
                    map1.ShowDialog();
                }
                else if (randsayi == 1) {
                    map2.ShowDialog();
                }
            }
            else if (rdbtn_2.Checked == true) {

            }
            else if (rdbtn_3.Checked == true) {

            }
            else if (rdbtn_4.Checked == true) {

            }
            else if (rdbtn_5.Checked == true) {

            }
            else if (rdbtn_6.Checked == true) {

            }
            else {
                MessageBox.Show("Lütfen bir zorluk seçiniz...");
                this.Show();
            }
        }
    }
}