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
            linkedlist.Push("wowwwww");
            linkedlist.Traverse();

            Console.WriteLine("---------------------------");

            Console.WriteLine($"Pop result: {linkedlist.Pop()}");
            linkedlist.Traverse();
            Console.WriteLine("---------------------------");

            Console.WriteLine($"Shift result: {linkedlist.Shift()}");
            linkedlist.Traverse();

            Console.WriteLine("---------------------------");

            Console.WriteLine($"Pop result: {linkedlist.Pop()}");
            linkedlist.Traverse();

            Console.WriteLine("---------------------------");

            Console.WriteLine($"Shift result: {linkedlist.Shift()}");
            linkedlist.Traverse();

            Console.WriteLine("---------------------------");

            linkedlist.Unshift("Hello");
            linkedlist.Unshift("World");
            linkedlist.Push("!!!");
            linkedlist.Unshift("wowwwww");
            linkedlist.Traverse();
        }
    }
}