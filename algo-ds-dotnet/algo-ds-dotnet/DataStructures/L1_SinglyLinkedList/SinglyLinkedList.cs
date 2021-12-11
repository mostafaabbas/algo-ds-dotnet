using System;

namespace algo_ds_dotnet.DataStructures.L1_SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public int Length { get; set; }


        public void Push(T val)
        {
            var node = new Node<T>(val);
            if (Head == null)
                Head = node;
            if (Tail != null)
                Tail.Next = node;
            Tail = node;

            Length++;
        }

        public void Traverse()
        {
            var current = Head;
            Console.WriteLine($"Linked length is: {Length}");

            while (current != null)
            {
                Console.Write($"{current.Value} -> ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public T Pop()
        {
            T last = default(T);

            if (Length == 0)
                return last;

            last = Tail.Value;

            if (Length == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                var current = Head;

                Node<T> pre = current;
                while (current.Next != null)
                {
                    pre = current;
                    current = current.Next;
                }

                Tail = pre;
                Tail.Next = null;
            }

            Length--;
            return last;
        }
    }
}