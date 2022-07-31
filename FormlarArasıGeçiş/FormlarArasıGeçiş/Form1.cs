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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //KULLANICI ADI VE ŞİFRE DOĞRU İSE FORM 2'YE GEÇİŞ YAPILACAK BUNUN İÇİN KULLANICI VE ŞİFRE BİLGİLERİNİ GİRİYORUZ
            if (kullanıcıtextbox.Text== "kureysi" &&  şifretextbox.Text=="123")
            {
                //FORM 2'YE GEÇİŞ GEÇİŞ KODLARI
                Form2 form2 = new Form2();
                form2.Show();
                //form 2 açıldıktan sonra form1 i kapatmak için 
                this.Hide();
            }
            else
            {
                //Giriş bilgileri yanlış ise ekrana uyarı mesajı gönderiyoruz
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
        }
    }
}
