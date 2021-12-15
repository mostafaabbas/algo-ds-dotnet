using algo_ds_dotnet.DataStructures.L4_Trees.BinarySearchTrees;

namespace algo_ds_dotnet.DataStructures.L4_Trees.DepthFirstSearch_DFS
{
    public static class DFS_Test
    {
        public static void Run()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Insert(50);
            tree.Insert(75);
            tree.Insert(30);
            tree.Insert(3);
            tree.Insert(99);
            tree.Insert(10);
            tree.Insert(66);

            DFS_PreOrder<int>.BF_Search_PreOrder(tree);
            DFS_PostOrder<int>.BF_Search_PostOrder(tree);
            DFS_InOrder<int>.BF_Search_InOrder(tree);
        }
    }
}