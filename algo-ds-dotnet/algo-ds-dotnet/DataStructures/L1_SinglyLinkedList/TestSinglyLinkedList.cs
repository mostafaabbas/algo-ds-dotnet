using System;

namespace algo_ds_dotnet.DataStructures.L1_SinglyLinkedList
{
    public static class TestSinglyLinkedList
    {
        public static void Run()
        {
            var linkedlist = new SinglyLinkedList<string>();

            linkedlist.Traverse();

            Console.WriteLine("---------------------------");

            linkedlist.Push("Hello");
            linkedlist.Push("World");
            linkedlist.Push("!!!");
            linkedlist.Traverse();

            Console.WriteLine("---------------------------");

            Console.WriteLine($"Pop result: {linkedlist.Pop()}");
            linkedlist.Traverse();
            Console.WriteLine("---------------------------");

            Console.WriteLine($"Pop result: {linkedlist.Pop()}");
            linkedlist.Traverse();

            Console.WriteLine("---------------------------");

            Console.WriteLine($"Pop result: {linkedlist.Pop()}");
            linkedlist.Traverse();

            Console.WriteLine("---------------------------");

            Console.WriteLine($"Pop result: {linkedlist.Pop()}");
            linkedlist.Traverse();
        }
    }
}