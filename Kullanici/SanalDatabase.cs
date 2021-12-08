using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanici
{
    public class SanalDatabase
    {
        public static List<Kullanici> KullaniciTablo = new List<Kullanici>();
        static SanalDatabase()
        {
            KullaniciTablo.Add(new Kullanici()
            {
                id = 1,
                isim = "salih",
                soyisim = "koç",
                kullaniAdi = "salih",
                sifre = "1",
                aciklama = "ProfilBilgisi"
            });
        }
    }
}
