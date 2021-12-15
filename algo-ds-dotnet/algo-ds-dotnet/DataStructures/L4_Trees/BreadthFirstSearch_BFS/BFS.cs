using algo_ds_dotnet.DataStructures.L3_StacksQueues.Queues;
using algo_ds_dotnet.DataStructures.L4_Trees.BinarySearchTrees;
using System;

namespace algo_ds_dotnet.DataStructures.L4_Trees.BreadthFirstSearch_BFS
{
    public static class BFS<T> where T : IComparable<T>
    {
        public static CustomQueue<T> BF_Search(BinarySearchTree<T> tree)
        {
            if (tree == null || tree.Root == null)
                return null;

            CustomQueue<BinarySearchTreeNode<T>> queue = new CustomQueue<BinarySearchTreeNode<T>>();
            CustomQueue<T> visited = new CustomQueue<T>();
            BinarySearchTreeNode<T> node = tree.Root;

            queue.Enqueue(node);
            while (queue.Size > 0)
            {
                node = queue.Dequeue();
                if (node.Left != null)
                    queue.Enqueue(node.Left);
                if (node.Right != null)
                    queue.Enqueue(node.Right);

                visited.Enqueue(node.Value);
            }

            visited.Traverse();
            return visited;
        }
    }
}