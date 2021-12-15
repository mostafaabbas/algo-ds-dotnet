using algo_ds_dotnet.DataStructures.L3_StacksQueues.Queues;
using algo_ds_dotnet.DataStructures.L4_Trees.BinarySearchTrees;
using System;

namespace algo_ds_dotnet.DataStructures.L4_Trees.DepthFirstSearch_DFS
{
    public static class DFS_PostOrder<T> where T : IComparable<T>
    {
        public static CustomQueue<T> BF_Search_PostOrder(BinarySearchTree<T> tree)
        {
            if (tree == null || tree.Root == null)
                return null;

            CustomQueue<T> visited = new CustomQueue<T>();

            void Traverse(BinarySearchTreeNode<T> node)
            {
                if (node.Left != null)
                    Traverse(node.Left);
                if (node.Right != null)
                    Traverse(node.Right);
                visited.Enqueue(node.Value);
            }

            Traverse(tree.Root);

            visited.Traverse();
            return visited;
        }
    }
}