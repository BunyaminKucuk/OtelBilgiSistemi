using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    class Heap
    {
        public Otel[] heapArray;
        private int maxSize;
        private int currentSize;
        public Heap(int maxHeapSize)
        {
            this.maxSize = maxHeapSize;
            this.heapArray = new Otel[maxSize];
            currentSize = 0;

        }
        public bool Boş()
        {
            return currentSize == 0;        
        }

        public bool Ekle(Otel otel)
        {
            if (currentSize == maxSize)
                return false;

            heapArray[currentSize] = otel;

            MoveToUp(currentSize++);
            return true;
        }

        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            Otel bottom = heapArray[index];
            while (index > 0 && heapArray[parent].otelPuanı < bottom.otelPuanı)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public Otel RemoveMax() 
        {
            Otel root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            Otel top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                //Find larger child
                if (rightChild < currentSize && heapArray[leftChild].otelPuanı < heapArray[rightChild].otelPuanı)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.otelPuanı >= heapArray[largerChild].otelPuanı)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }

        public string[] Sort()
        {
            Heap h = new Heap(heapArray.Length);

            string[] sorted = new string[heapArray.Length];
          
            foreach (Otel item in heapArray)
                h.Ekle(item);

            int i = 0;
          
            while (!h.Boş())
            {
                sorted[i++] = h.RemoveMax().ad;
            }               
            return sorted;
        }


        public string[] YıldızSort()
        {
            Heap h = new Heap(heapArray.Length);

            foreach (Otel item in heapArray)
                h.Ekle(item);

            for(int i=0;i<heapArray.Length;i++)
                for(int j=i+1;j<heapArray.Length;j++)
                {
                    if(h.heapArray[i].yıldızSayısı<h.heapArray[j].yıldızSayısı)
                    {
                        Otel temp = h.heapArray[i];
                        h.heapArray[i] = h.heapArray[j];
                        h.heapArray[j] = temp;
                    }
                }
            string[] sorted = new string[heapArray.Length];

            int x = 0;
            while (!h.Boş())
                sorted[x++] = h.RemoveMax().ad;

            return sorted;
        }
    }
}
