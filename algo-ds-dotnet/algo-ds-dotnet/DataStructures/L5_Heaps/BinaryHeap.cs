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
    }
}