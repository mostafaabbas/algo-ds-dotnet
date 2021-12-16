namespace algo_ds_dotnet.DataStructures.L5_Heaps
{
    public class PriorityQueueNode<T>
    {
        public PriorityQueueNode(T value, int priority)
        {
            Value = value;
            Priority = priority;
        }


        public T Value { get; set; }

        public int Priority { get; set; }
    }
}