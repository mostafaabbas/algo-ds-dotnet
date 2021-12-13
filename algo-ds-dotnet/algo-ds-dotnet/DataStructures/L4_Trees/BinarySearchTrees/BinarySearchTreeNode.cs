namespace algo_ds_dotnet.DataStructures.L4_Trees.BinarySearchTrees
{
    public class BinarySearchTreeNode<T>
    {
        public BinarySearchTreeNode(T value)
        {
            Value = value;
        }


        public T Value { get; set; }

        public BinarySearchTreeNode<T> Right { get; set; }

        public BinarySearchTreeNode<T> Left { get; set; }
    }
}