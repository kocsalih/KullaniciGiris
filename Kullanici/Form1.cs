using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbnKullanici_Click(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullanici.Text;
            string sifre = txtSifre.Text;

            Kullanici bulunanKullanici = SanalDatabase.KullaniciTablo.Find(i => i.kullaniAdi == kullaniciAdi && i.sifre == sifre);
            if (bulunanKullanici != null)
            {
                AnaForm _anaForm = new AnaForm(bulunanKullanici);
                _anaForm.Show();
            }
            else
            {
                MessageBox.Show("HATA!"); 
            }
           
         
        }

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKullanici_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            //T1.BackColor = Color.Transparent;
        }
    }
}
