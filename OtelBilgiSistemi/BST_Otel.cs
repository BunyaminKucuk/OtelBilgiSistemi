using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    class BST_Otel
    {
       public OtelNode kök;
        string düğümbilgileri;
        public LinkedList<Otel> oteller = new LinkedList<Otel>();
     
        public int DugumSayisiBul()
        {
            return DugumSayisiBul(kök);
        }

        public int DugumSayisiBul(OtelNode dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisiBul(dugum.sol);
                count += DugumSayisiBul(dugum.sağ);
            }
            return count;
        }

        public int DerinlikBul()
        {
            OtelNode otel = kök;
            int derinlik = 0;
            while(otel.sol!=null || otel.sağ!=null)
            {
                if (otel.sol != null)
                {
                    otel = otel.sol;
                    derinlik++;
                }
                else if(otel.sağ!=null)
                {
                    otel = otel.sağ;
                    derinlik++;
                }
                    
            }
            return derinlik;
        }

        public string DugumleriYazdir()
        {
            return düğümbilgileri;
        }

        public void PreOrder()
        {
           düğümbilgileri = "";
           PreOrderInt(kök);

        }

        private void PreOrderInt(OtelNode dugum)
        {
            if (dugum == null)
                return ;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sağ);

        }

        public void InOrder()
        {
            düğümbilgileri = "";
            InOrderInt(kök);
        }

        private void InOrderInt(OtelNode dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sağ);
        }

        private void Ziyaret(OtelNode dugum)
        {
            düğümbilgileri += dugum.otel.ad + " " + "|| " + dugum.otel.il + " "+ "|| " + dugum.otel.ilçe + " " + "|| " + dugum.otel.adres + " " + "|| " + dugum.otel.telefon + " " + "|| " + dugum.otel.eposta +" "+ "|| " + dugum.otel.odaTipleri  + " " + "|| " + dugum.otel.yıldızSayısı.ToString() + " " + "|| " + dugum.otel.otelPuanı.ToString() + " " + "|| " + dugum.otel.odaSayısı.ToString() + Environment.NewLine + Environment.NewLine;

        }

        public void PostOrder()
        {
            düğümbilgileri = "";
            PostOrderInt(kök);
        }

        private void PostOrderInt(OtelNode dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sağ);
            Ziyaret(dugum);
        }

        public void Ekle(Otel Otel)
        {
          
            OtelNode tempParent = new OtelNode();
         
            OtelNode tempSearch = kök;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
               
                if (Otel.ad == tempSearch.otel.ad)
                    return;
                else if (string.Compare(tempSearch.otel.ad,Otel.ad)==1) 
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sağ;
            }
            OtelNode eklenecek = new OtelNode(Otel);
            
            if (kök == null)
                kök = eklenecek;
            else if (string.Compare(tempParent.otel.ad, Otel.ad) == 1) 
                tempParent.sol = eklenecek;
            else
                tempParent.sağ = eklenecek;

            oteller.AddLast(eklenecek.otel);
        }

        public OtelNode Ara(string anahtar)
        {
            return AraInt(kök,anahtar);
        }

        private OtelNode AraInt(OtelNode dugum, string anahtar)
        {
            if (dugum == null)
                return null;
            else if (dugum.otel.ad == anahtar)
                return dugum;
            else if (string.Compare(dugum.otel.ad,anahtar)==1)
                return (AraInt(dugum.sol, anahtar));
            else
                return (AraInt(dugum.sağ, anahtar));
        }

        private OtelNode Successor(OtelNode silDugum)
        {
            OtelNode successorParent = silDugum;
            OtelNode successor = silDugum;
            OtelNode current = silDugum.sağ;
            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.sol;
            }
            if (successor != silDugum.sağ)
            {
                successorParent.sol = successor.sağ;
                successor.sağ = silDugum.sağ;
            }
            return successor;
        }

        public bool Sil(string OtelAdı)
        {
            oteller.Remove(Ara(OtelAdı).otel);
            OtelNode current = kök;
            OtelNode parent = kök;
            bool issol = true;
            //DÜĞÜMÜ BUL
            while (current.otel.ad != OtelAdı)
            {
                parent = current;
                if (string.Compare(current.otel.ad,OtelAdı)==1)
                {
                    issol = true;
                    current = current.sol;
                }
                else
                {
                    issol = false;
                    current = current.sağ;
                }
                if (current == null)
                    return false;
            }
            //DURUM 1: YAPRAK DÜRÜM
            if (current.sol == null && current.sağ == null)
            {
                if (current == kök)
                    kök = null;
                else if (issol)
                    parent.sol = null;
                else
                    parent.sağ = null;
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
            else if (current.sağ == null)
            {
                if (current == kök)
                    kök = current.sol;
                else if (issol)
                    parent.sol = current.sol;
                else
                    parent.sağ = current.sol;
            }
            else if (current.sol == null)
            {
                if (current == kök)
                    kök = current.sağ;
                else if (issol)
                    parent.sol = current.sağ;
                else
                    parent.sağ = current.sağ;
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            else
            {
                OtelNode successor = Successor(current);
                if (current == kök)
                    kök = successor;
                else if (issol)
                    parent.sol = successor;
                else
                    parent.sağ = successor;
                successor.sol = current.sol;
            }

            
            return true;
        }
    }
}
