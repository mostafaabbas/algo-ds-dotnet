using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.DataStructures.L5_Heaps
{
    public static class Heaps_Test
    {
        public static void Run()
        {
            BinaryHeap<int> binaryHeap = new BinaryHeap<int>();
            binaryHeap.Insert(50);
            binaryHeap.Insert(45);
            binaryHeap.Insert(33);
            binaryHeap.Insert(40);
            binaryHeap.Insert(23);
            binaryHeap.Insert(30);
            binaryHeap.Insert(25);
            Console.WriteLine(string.Join(" -> ", binaryHeap.Values));
            binaryHeap.Insert(43);
            Console.WriteLine(string.Join(" -> ", binaryHeap.Values));
            binaryHeap.Insert(100);
            Console.WriteLine(string.Join(" -> ", binaryHeap.Values));

            Console.WriteLine($"ExtractMax: {binaryHeap.RemoveRoot_ExtractMax()}");
            //binaryHeap.RemoveRoot_ExtractMax();
            Console.WriteLine(string.Join(" -> ", binaryHeap.Values));
        }
    }
}