using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    public class Yorum
    {
        Müşteri oturum = DBİşlemleri.GetInstance().OturumMüşteri;
         public string yorum { get; set;}
        public string sahipAdı { get;  set;}
        public string sahipSoyadı { get;  set;}
        public string sahipEpostası { get; set;}

        public Yorum(string Yorum)
        {
            this.yorum = Yorum;
            this.sahipAdı = oturum.ad;
            this.sahipSoyadı = oturum.soyad;
            this.sahipEpostası = oturum.eposta;

        }

    }
}
