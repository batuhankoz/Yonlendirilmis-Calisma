using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batu
{
   
    class Program
    {
        public static misafir_anaekran ilk_sayfa = new misafir_anaekran();
        static void Main(string[] args)
        {
            ilk_sayfa.ShowDialog();
            while (true) {
                    DialogResult dialogResult = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ?", "Çıkış yapıyorsunuz !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        break;
                    }
                    else
                    {
                        ilk_sayfa.ShowDialog();
                    }
            }
        }
    }
}