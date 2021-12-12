using System;

namespace algo_ds_dotnet.DataStructures.L2_DoublyLinkedList
{
    public static class TestDoublyLinkedList
    {
        public static void Run()
        {
            var linkedlist = new DoublyLinkedList<string>();

            linkedlist.Traverse();

            Console.WriteLine("--------------------------- Push");

            linkedlist.Push("Hello");
            linkedlist.Push("World");
            linkedlist.Push("!!!");
            linkedlist.Push("wowwwww");
            linkedlist.Traverse();

            Console.WriteLine("--------------------------- POP");

            Console.WriteLine($"Pop result: {linkedlist.Pop()}");
            linkedlist.Traverse();            
            Console.WriteLine($"Pop result: {linkedlist.Pop()}");
            linkedlist.Traverse();
            Console.WriteLine($"Pop result: {linkedlist.Pop()}");
            linkedlist.Traverse();
            Console.WriteLine($"Pop result: {linkedlist.Pop()}");
            linkedlist.Traverse();
            Console.WriteLine($"Pop result: {linkedlist.Pop()}");
            linkedlist.Traverse();

            Console.WriteLine("--------------------------- Shift");

            linkedlist.Push("Hello");
            linkedlist.Push("World");
            linkedlist.Push("!!!");
            linkedlist.Push("wowwwww");

            Console.WriteLine($"Shift result: {linkedlist.Shift()}");
            linkedlist.Traverse();
            Console.WriteLine($"Shift result: {linkedlist.Shift()}");
            linkedlist.Traverse();
            Console.WriteLine($"Shift result: {linkedlist.Shift()}");
            linkedlist.Traverse();
            Console.WriteLine($"Shift result: {linkedlist.Shift()}");
            linkedlist.Traverse();
            Console.WriteLine($"Shift result: {linkedlist.Shift()}");
            linkedlist.Traverse();

            Console.WriteLine("--------------------------- Unshift");

            linkedlist.Unshift("33333");
            linkedlist.Unshift("22222");
            linkedlist.Push("44444");
            linkedlist.Unshift("11111");

            linkedlist.Traverse();

            //Console.WriteLine($"This should be Hello: => {linkedlist.Get(2)}");
            //Console.WriteLine($"This should be !!!: => {linkedlist.Get(3)}");
            //Console.WriteLine($"This should be World: => {linkedlist.Get(1)}");
            //Console.WriteLine($"This should be wowwwww: => {linkedlist.Get(0)}");

            //Console.WriteLine("---------------------------");

            //linkedlist.Set("Second!", 1);
            //linkedlist.Traverse();

            //linkedlist.Set("First!", 0);
            //linkedlist.Traverse();

            //linkedlist.Set("RRR!", 10);
            //linkedlist.Traverse();

            //Console.WriteLine("---------------------------");

            //linkedlist.Insert("3333 inserted", 2);
            //linkedlist.Traverse();

            //Console.WriteLine("--------------------------- removing third");
            //linkedlist.Remove(2);
            //linkedlist.Traverse();

            //Console.WriteLine("--------------------------- reverse");
            //linkedlist.Reverse();
            //linkedlist.Traverse();
        }
    }
}