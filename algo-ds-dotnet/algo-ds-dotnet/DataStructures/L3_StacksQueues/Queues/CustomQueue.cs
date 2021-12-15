using System;

namespace algo_ds_dotnet.DataStructures.L3_StacksQueues.Queues
{
    public class CustomQueue<T>
    {
        public QueueNode<T> First { get; set; }

        public QueueNode<T> Last { get; set; }

        public int Size { get; set; }


        public void Traverse()
        {
            string str = "";
            var current = First;

            while (current != null)
            {
                str += current.Value + " -> ";
                current = current.Next;
            }

            Console.WriteLine(str);
        }


        public void Enqueue(T val)
        {
            var node = new QueueNode<T>(val);

            if (Size == 0)
                First = node;
            else
                Last.Next = node;
            Last = node;
            Size++;
        }

        public T Dequeue()
        {
            if (Size == 0) return default;
            var node = First;
            if (Size == 1)
                Last = null;
            else
                First = First.Next;
            Size--;
            return node.Value;
        }
    }
}