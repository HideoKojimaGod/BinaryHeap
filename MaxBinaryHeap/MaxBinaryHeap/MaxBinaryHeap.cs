using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxBinaryHeap
{
    class MaxBinaryHeap<T> : BinaryHeap<T> 
        where T : IComparable
    {
        public MaxBinaryHeap(params T[] heap) : base(heap)
        {
        }
        protected override void IncreaseKey(int pos)
        {
            while (pos > 0 && values[pos].CompareTo(values[(pos - 1) / 2]) > 0)
            {
                T changed = values[pos];
                values[pos] = values[(pos - 1) / 2];
                values[(pos - 1) / 2] = changed;
                pos = (pos - 1) / 2;
            }
        }
        public override void Heapify(int pos)
        {
            int left = 2 * pos + 1;
            int right = 2 * pos + 2;
            int largest = pos;
            if (left < Size && values[left].CompareTo(values[largest]) > 0) largest = left;
            if (right < Size && values[right].CompareTo(values[largest]) > 0) largest = right;
            if (largest != pos)
            {
                T changed = values[pos];
                values[pos] = values[largest];
                values[largest] = changed;
                Heapify(largest);
            }
        }
    }
}
