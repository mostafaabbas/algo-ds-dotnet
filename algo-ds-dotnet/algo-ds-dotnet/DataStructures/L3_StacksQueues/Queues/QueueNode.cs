namespace algo_ds_dotnet.DataStructures.L3_StacksQueues.Queues
{
    public class QueueNode<T>
    {
        public QueueNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public QueueNode<T> Next { get; set; }
    }
}