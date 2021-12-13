using System;

namespace algo_ds_dotnet.DataStructures.L4_Trees.BinarySearchTrees
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BinarySearchTreeNode<T> Root { get; set; }

        public void Insert(T val)
        {
            var newNode = new BinarySearchTreeNode<T>(val);

            if(Root == null)
            {
                Root = newNode;
                return;
            }

            var current = Root;

            while(current != null)
            {
                var compare = val.CompareTo(current.Value);
                if (compare > 0) //right
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        return;
                    }
                    
                    current = current.Right;
                }
                else if (compare < 0) //left
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                        return;
                    }
                    
                    current = current.Left;
                }
                else
                    return;
            }
        }
    }
}