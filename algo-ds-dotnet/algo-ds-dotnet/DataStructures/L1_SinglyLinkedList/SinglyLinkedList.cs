using System;

namespace algo_ds_dotnet.DataStructures.L1_SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public int Length { get; set; }


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


        #region push, pop

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

        #endregion

        #region shift, unshift

        public T Shift()
        {
            if (Length == 0) return default;

            var first = Head.Value;

            if (Length == 1)
            {
                Head = null;
                Tail = null;
            }
            else
                Head = Head.Next;

            Length--;
            return first;
        }

        public void Unshift(T val)
        {
            var node = new Node<T>(val);
            node.Next = Head;
            Head = node;
            if (Length == 0)
                Tail = node;
            Length++;
        }

        #endregion

        #region get, set

        public Node<T> Get(int index)
        {
            if (index < 0 || index >= Length || Length == 0)
                return null;

            if (Length == 1) return Head;
            if (index == Length - 1) return Tail;

            var counter = 0;
            var current = Head;
            while(counter <= index)
            {
                if (counter == index)
                    return current;
                current = current.Next;
                counter++;
            }

            return null;
        }

        public bool Set(T val, int index)
        {
            var nodeAtIndex = Get(index);
            if (nodeAtIndex != null)
            {
                nodeAtIndex.Value = val;
                return true;
            }
            return false;
        }

        #endregion


    }
}