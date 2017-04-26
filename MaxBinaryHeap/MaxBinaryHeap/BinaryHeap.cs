using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxBinaryHeap
{
   abstract class BinaryHeap<T>
        where T : IComparable
    {
        protected T[] values;
        public int Size
        {
            get
            {
                return values.Length;
            }
        }
        public BinaryHeap(params T[] heap)
        {
            values = new T[0];
            BuildHeap(heap); 
        }

        protected void BuildHeap(params T[] heap)
        {
            Array.Resize(ref values, heap.Length);
            values = heap;
            for (int i = (Size -1) / 2; i >= 0; i--) Heapify(i);
        }
        public abstract void Heapify(int pos);
        protected abstract void IncreaseKey(int pos);

        public void Insert(T key)
        {
            Array.Resize(ref values, Size + 1);
            values[Size - 1] = key;
            IncreaseKey(Size - 1);
        }


        public T Extract()
        {
            if (Size >= 1)
            {
                T max = values[0];
                values[0] = values.Last();
                Array.Resize(ref values, Size - 1);
                Heapify(0);
                return max;
            }
            throw new ArgumentNullException("Куча пустая");
        }

        //public void Out()
        //{
        //    for (int i =0; i<Size;i++)
        //    {
        //        Console.Write(values[i] + " ");
        //    }
        //    Console.WriteLine();
        //}

    }
}
