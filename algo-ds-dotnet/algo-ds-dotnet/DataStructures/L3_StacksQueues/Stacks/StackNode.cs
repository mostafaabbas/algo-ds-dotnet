namespace algo_ds_dotnet.DataStructures.L3_StacksQueues.Stacks
{
    public class StackNode<T>
    {
        public StackNode(T value)
        {
            Value = value;
        }


        public T Value { get; set; }

        public StackNode<T> Previous { get; set; }
    }
}