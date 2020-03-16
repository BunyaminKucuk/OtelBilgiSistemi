using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    class HashTable
    {
        int tabloCount;
       public Hashİçerik[] tablo;

        public HashTable(int tabloCount)
        {
            this.tabloCount = tabloCount;
            this.tablo = new Hashİçerik[tabloCount];
            for (int i = 0; i < tabloCount; i++)
                this.tablo[i] = null;           
        }



        public void HeapYeriAç(int a,string il)
        {
            int hash = HashVer(il);
            this.tablo[hash] = new Hashİçerik(il, a);
        }

        public void AddOtel(Otel value,string kıstas)
        {
            int hash = HashVer(kıstas);
            this.tablo[hash].OtelHeap.Ekle(value);
            
        }

        private int HashVer(string key)
        {
            int IntKey = StringDönüştürücü(key);

            int hash = (IntKey % tabloCount);
            while (tablo[hash] != null && tablo[hash].anahtar != IntKey)
                hash = (hash + 1) % tabloCount;

            return hash;
        }

        private int StringDönüştürücü(string StringKey)
        {
            int IntKey = 0;
            int i = 0;

            foreach (char a in StringKey)
            {
                IntKey += StringKey[i];
                i++;
            }

            return IntKey;
        }

        public Heap GetHeap(string key)
        {
            int IntKey = StringDönüştürücü(key);

            int hash = (IntKey % tabloCount);
            int i = 0;

           while (tablo[hash] != null && tablo[hash].anahtar != IntKey)
            {
                hash = (hash + 1) % tabloCount;

                if (i == tabloCount)
                    return null;

                i++;
            }                
            if (tablo[hash] == null)
                return null;
            else
                return tablo[hash].OtelHeap;
       }
    }
}
