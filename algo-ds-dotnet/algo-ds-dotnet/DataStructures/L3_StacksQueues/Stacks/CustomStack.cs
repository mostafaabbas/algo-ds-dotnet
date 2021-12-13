namespace algo_ds_dotnet.DataStructures.L3_StacksQueues.Stacks
{
    public class CustomStack<T>
    {
        public StackNode<T> First { get; set; }

        public StackNode<T> Last { get; set; }

        public int Size { get; set; }


        public void Push(T val)
        {
            var newNode = new StackNode<T>(val);
            if (Size == 0)
                First = newNode;
            else
                newNode.Previous = Last;
            Last = newNode;

            Size++;
        }

        public T Pop()
        {
            if (Size == 0) return default;

            var lastNode = Last;
            Last = Last.Previous;
            if (Size == 1)
                First = null;
            Size--;
            return lastNode.Value;
        }
    }
}