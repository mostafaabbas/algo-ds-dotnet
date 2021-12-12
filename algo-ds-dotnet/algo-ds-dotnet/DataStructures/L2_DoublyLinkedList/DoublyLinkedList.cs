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

        #region get, set

        public Node<T> Get(int position)
        {
            if (position < 0 || position >= Length)
                return null;

            var middle = Math.Floor((decimal)Length / 2);
            Node<T> node = null;

            if (position > middle)
            {
                int counter = Length - 1;
                node = Tail;
                while (counter != position)
                {
                    node = node.Previous;
                    counter--;
                }
            }
            else
            {
                int counter = 0;
                node = Head;
                while (counter != position)
                {
                    node = node.Next;
                    counter++;
                }
            }

            //node.Previous = null;
            //node.Next = null;
            return node;
        }

        public void Set(T val, int position)
        {
            var node = Get(position);
            if (node != null)
                node.Value = val;
        }

        #endregion

        #region insert

        public void Insert(T val, int position)
        {
            if (position < 0 || position > Length)
                return;
            else if (position == Length)
                Push(val);
            else if (position == 0)
                Unshift(val);
            else
            {
                var newNode = new Node<T>(val);
                var nodeAtIndex = Get(position);
                var nodeBefore = Get(position - 1);

                newNode.Next = nodeAtIndex;
                nodeAtIndex.Previous = newNode;

                newNode.Previous = nodeBefore;
                nodeBefore.Next = newNode;

                Length++;
            }
        }

        public void Remove(int position)
        {
            if (position < 0 || position >= Length)
                return;
            else if (position == Length - 1)
                Pop();
            else if (position == 0)
                Shift();
            else
            {
                //var nodeBefore = Get(position - 1);
                //var nodeAfter = Get(position + 1);
                //nodeBefore.Next = nodeAfter;
                //nodeAfter.Previous = nodeBefore;

                var nodeToRemove = Get(position);
                nodeToRemove.Previous.Next = nodeToRemove.Next;
                nodeToRemove.Next.Previous = nodeToRemove.Previous;
            }
        }

        #endregion
    }
}