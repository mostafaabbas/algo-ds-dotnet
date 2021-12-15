using algo_ds_dotnet.DataStructures.L4_Trees.BinarySearchTrees;

namespace algo_ds_dotnet.DataStructures.L4_Trees.BreadthFirstSearch_BFS
{
    public static class BFS_Test
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

            BFS<int>.BF_Search(tree);
        }
    }
}