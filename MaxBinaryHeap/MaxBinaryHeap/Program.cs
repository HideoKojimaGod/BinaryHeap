using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxBinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            var heap = new MaxBinaryHeap<int>(1, 2, 3, 4, 5, 6, 7, 8, 9);
            var heap1 = new MinBinaryHeap<int>(1, 8, 11, 45, 111, 6, 7, 2, 9);
        }

    }
}
