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
    public partial class AnaForm : Form
    {
        public AnaForm(Kullanici bulunanKullanici)
        {
            InitializeComponent();

            textBox1.Text = bulunanKullanici.isim;
            textBox2.Text = bulunanKullanici.soyisim;
            textBox3.Text = bulunanKullanici.kullaniAdi;
            textBox4.Text= bulunanKullanici.sifre;
            textBox5.Text = bulunanKullanici.aciklama;
            btnguncelle.Tag = bulunanKullanici.id;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = (int)btnguncelle.Tag;
            int index = SanalDatabase.KullaniciTablo.FindIndex(i => i.id == id);
            SanalDatabase.KullaniciTablo[index].isim = textBox1.Text;
            SanalDatabase.KullaniciTablo[index].soyisim = textBox2.Text;
            SanalDatabase.KullaniciTablo[index].kullaniAdi = textBox3.Text;
            SanalDatabase.KullaniciTablo[index].sifre = textBox4.Text;
            SanalDatabase.KullaniciTablo[index].aciklama = textBox5.Text;
        }
    }
}
