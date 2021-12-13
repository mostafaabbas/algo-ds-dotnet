using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.DataStructures.L4_Trees.BinarySearchTrees
{
    public static class BST_Test
    {
        public static void Run()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Insert(50);
            tree.Insert(25);

        }
    }
}