using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    public class Otel
    {
        public string ad;
        public string il;
        public string ilçe;
        public string adres;
        public string telefon;
        public string eposta;
        public int yıldızSayısı;
        public int odaSayısı;
        public double otelPuanı=0;
        public string odaTipleri;
        public LinkedList<Personel> personeller = new LinkedList<Personel>();
        public LinkedList<Yorum> yorumlar = new LinkedList<Yorum>();

        public static void OtelSil(Otel otel)
        {
            otel = null;
        }

        public void PersonelEkle(Personel personel)
        {          
          personeller.AddLast(personel);
        }

        public void PersonelÇıkar(Personel personel)
        {
            personeller.Remove(personel);
        }

        public Personel PersonelAra(string Ad)
        {
            foreach(Personel a in personeller)
            {
                if(Ad.ToLower()==a.ad.ToLower())
                {
                    return a;
                }
            }
            return null;
        }

        public void YorumEkle(Yorum yorum)
        {
            yorumlar.AddLast(yorum);
        }


    }
}
