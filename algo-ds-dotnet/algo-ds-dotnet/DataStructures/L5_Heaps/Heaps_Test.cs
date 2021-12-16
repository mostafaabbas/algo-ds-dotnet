using System;
using System.Linq;

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

            Console.WriteLine("************* priority queue ********************");

            PriorityQueue<string> pq = new PriorityQueue<string>();
            pq.Enqueue("common cold", 5);
            pq.Enqueue("high fever", 2);
            pq.Enqueue("low fever", 3);
            pq.Enqueue("injury", 1);
            Console.WriteLine(string.Join(" -> ", pq.Values.Select(c => c.Value)));

        }
    }
}