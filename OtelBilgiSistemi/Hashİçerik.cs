using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    class Hashİçerik
    {
        public int anahtar;
        public Heap OtelHeap;

      
        public Hashİçerik(string anahtar,int ints)
        {
            this.anahtar = StringDönüştürücü(anahtar);
            this.OtelHeap = new Heap(ints);
        }

        private int StringDönüştürücü(string StringKey)
        {
            int IntAnahtar = 0;
            int i = 0;
            foreach (char a in StringKey)
            {
                IntAnahtar += StringKey[i];
                i++;
            }
            return IntAnahtar;
        }

    }
}
