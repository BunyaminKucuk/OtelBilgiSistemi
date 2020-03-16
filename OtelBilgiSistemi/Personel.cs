using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    public class Personel
    {
        public string tcKimlikNo;
        public string ad;
        public string soyad;
        public string telefon;
        public string adres;
        public string eposta;
        public string departman;
        public  string pozisyon;
        public int personelPuanı=0;
   
        public static void PersonelSil(Personel personel)
        {
            personel = null;
        }

    }
}
