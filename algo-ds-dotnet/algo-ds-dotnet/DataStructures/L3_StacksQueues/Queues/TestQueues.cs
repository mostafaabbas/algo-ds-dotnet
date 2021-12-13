using System;

namespace algo_ds_dotnet.DataStructures.L3_StacksQueues.Queues
{
    public static class TestQueues
    {
        public static void Run()
        {
            var queue = new CustomQueue<string>();
            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");

            Console.WriteLine($"{queue.First.Value} -> {queue.Last.Value}");

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine($" -> {queue.First?.Value} -> {queue.Last?.Value}");
        }
    }
}