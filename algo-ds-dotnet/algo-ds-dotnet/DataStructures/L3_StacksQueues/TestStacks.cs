using System;

namespace algo_ds_dotnet.DataStructures.L3_StacksQueues
{
    public static class TestStacks
    {
        public static void Run()
        {
            var stack = new CustomStack<string>();
            stack.Push("first");
            stack.Push("second");
            stack.Push("third");

            Console.WriteLine($"{stack.First.Value} -> {stack.Last.Value}");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine($" -> {stack.First?.Value} -> {stack.Last?.Value}");
        }
    }
}