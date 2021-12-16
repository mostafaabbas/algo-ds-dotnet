using System;
using System.Collections.Generic;

namespace algo_ds_dotnet.DataStructures.L5_Heaps
{
    public class BinaryHeap<T> where T : IComparable<T>
    {
        public BinaryHeap()
        {
            Values = new List<T>();
        }
        public List<T> Values { get; private set; }


        public void Insert(T value)
        {
            Values.Add(value);
            var index = Values.Count - 1; //_values.IndexOf

            while (true)
            {
                int parentIndex = (int)Math.Floor((decimal)(index - 1) / 2);
                if (parentIndex < 0)
                    return;

                var parent = Values[parentIndex];
                var compare = value.CompareTo(parent);
                if (compare > 0)
                {//swap
                    Values[parentIndex] = Values[index];
                    Values[index] = parent;
                    index = parentIndex;
                }
                else
                    return;
            }
        }


        public T RemoveRoot_ExtractMax()
        {
            if (Values.Count == 0) return default;

            var root = Values[0];
            var shiftedNode = Values[Values.Count - 1];
            Values[0] = shiftedNode;
            Values.RemoveAt(Values.Count - 1);
            var index = 0;

            while (true)
            {
                var leftChildIndex = (2 * index) + 1; //2n + 1
                var rightChildIndex = (2 * index) + 2; //2n + 2

                if (leftChildIndex >= Values.Count)
                    break;

                var left = Values[leftChildIndex];
                var right = rightChildIndex < Values.Count ? Values[rightChildIndex] : default;

                if (shiftedNode.CompareTo(left) < 0 || shiftedNode.CompareTo(right) < 0)
                {
                    if(left.CompareTo(right) > 0)
                    {
                        Values[index] = left;
                        Values[leftChildIndex] = shiftedNode;
                        shiftedNode = left;
                        index = leftChildIndex;
                    }
                    else
                    {
                        Values[index] = right;
                        Values[rightChildIndex] = shiftedNode;
                        shiftedNode = right;
                        index = rightChildIndex;
                    }
                }
                else
                    break;
            }

            return root;
        }
    }
}