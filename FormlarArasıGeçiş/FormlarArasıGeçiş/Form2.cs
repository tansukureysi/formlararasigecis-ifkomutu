using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasıGeçiş
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void calistirbutton_Click(object sender, EventArgs e)
        {
            //combobox'a girilen renk beyaz ise çıktısına 'Beyaz rengi saflığı temsil eder.' yazdırıyoruz.
            if (renkcombo.Text == "Kırmızı")
            {
                //çıktıda yazacak yazıyı giriyoruz
                cikti.Text = "Kırmızı rengi mutluluğu temsil eder.";
                //renk butonun rengini belirliyoruz
                renkbutonu.BackColor = Color.Red;
                //çıktıda yazacak cümlenin arka planın rengini ayarlıyoruz
                cikti.BackColor = Color.Red;

            }
            if (renkcombo.Text == "Pembe")
            {
                cikti.Text = "Pembe rengi şefkati temsil eder.";
                renkbutonu.BackColor = Color.Pink;
                cikti.BackColor = Color.Pink;

            }
            if (renkcombo.Text == "Siyah")
            {
                cikti.Text = "Siyah rengi gücü temsil eder.";
                renkbutonu.BackColor = Color.Black;
                cikti.BackColor = Color.Black;

            }
            if (renkcombo.Text == "Turuncu")
            {
                cikti.Text = "Turuncu rengi canlılığı temsil eder.";
                renkbutonu.BackColor = Color.Orange;
                cikti.BackColor = Color.Orange;

            }
            if (renkcombo.Text == "Mavi")
            {
                cikti.Text = "Mavi rengi dürüstlüğü temsil eder.";
                renkbutonu.BackColor = Color.AliceBlue;
                cikti.BackColor = Color.AliceBlue;


            }
            if (renkcombo.Text == "Yeşil")
            {
                cikti.Text = "Yeşil rengi güveni temsil eder.";
                renkbutonu.BackColor = Color.LightGreen;
                cikti.BackColor= Color.LightGreen;
            }
        }
    }
}
