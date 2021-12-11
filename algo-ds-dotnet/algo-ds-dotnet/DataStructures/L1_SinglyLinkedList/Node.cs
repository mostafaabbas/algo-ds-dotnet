namespace algo_ds_dotnet.DataStructures.L1_SinglyLinkedList
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }


        public T Value { get; set; }

        public Node<T> Next { get; set; }
    }
}