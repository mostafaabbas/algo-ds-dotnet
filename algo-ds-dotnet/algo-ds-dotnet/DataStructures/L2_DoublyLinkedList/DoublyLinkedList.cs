using System;

namespace algo_ds_dotnet.DataStructures.L2_DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public int Length { get; set; }


        public void Traverse()
        {
            var current = Head;
            Console.WriteLine($"length is: {Length}");

            while (current != null)
            {
                Console.Write($"{current.Value} -> ");
                current = current.Next;
            }
            Console.WriteLine("");
            Console.WriteLine("*************");
        }


        #region push, pop

        public void Push(T val)
        {
            var node = new Node<T>(val);

            if (Length == 0)
                Head = node;
            else
            {
                node.Previous = Tail;
                Tail.Next = node;
            }

            Tail = node;
            Length++; 
        }

        public T Pop()
        {
            if (Length == 0) return default;

            var poppedNode = Tail;
            if (Length == 1)
                Head = null;
            Tail = Tail.Previous;
            if (Tail != null)
                Tail.Next = null;
            Length--;

            poppedNode.Previous = null;
            return poppedNode.Value;
        }

        #endregion

        #region shift, unshift

        public T Shift()
        {
            if (Length == 0) return default;

            var shiftedNode = Head;
            if(Length == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Previous = null;
                shiftedNode.Next = null;
            }

            Length--;
            return shiftedNode.Value;
        }

        public void Unshift(T val)
        {
            var node = new Node<T>(val);
            if(Length == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head.Previous = node;
                Head = node;
            }

            Length++;
        }

        #endregion
    }
}