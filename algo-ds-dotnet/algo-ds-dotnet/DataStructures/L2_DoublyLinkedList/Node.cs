namespace algo_ds_dotnet.DataStructures.L2_DoublyLinkedList
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }


        public T Value { get; set; }

        public Node<T> Next { get; set; }

        public Node<T> Previous { get; set; }
    }
}