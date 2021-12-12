using System;

namespace algo_ds_dotnet.DataStructures.L2_DoublyLinkedList
{
    public static class TestDoublyLinkedList
    {
        public static void Run()
        {
            var linkedlist = new DoublyLinkedList<string>();

            linkedlist.Traverse();

            Console.WriteLine("----------------------------------------- Push");

            linkedlist.Push("Hello");
            linkedlist.Push("World");
            linkedlist.Push("!!!");
            linkedlist.Push("wowwwww");
            linkedlist.Traverse();

            Console.WriteLine("----------------------------------------- POP");

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

            Console.WriteLine("----------------------------------------- Shift");

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

            Console.WriteLine("----------------------------------------- Unshift");

            linkedlist.Unshift("2222");
            linkedlist.Unshift("1111");
            linkedlist.Push("3333");
            linkedlist.Unshift("0000");

            linkedlist.Traverse();

            Console.WriteLine("----------------------------------------- get");

            linkedlist.Push("4444");
            linkedlist.Push("5555");
            linkedlist.Push("6666");
            linkedlist.Push("7777");
            //linkedlist.Push("8888");
            //linkedlist.Push("9999");
            Console.WriteLine($"This should be 2222: => {linkedlist.Get(2).Value}");
            Console.WriteLine($"This should be 3333: => {linkedlist.Get(3).Value}");
            Console.WriteLine($"This should be 6666: => {linkedlist.Get(6).Value}");
            Console.WriteLine($"This should be Null: => {linkedlist.Get(50)}");

            Console.WriteLine("----------------------------------------- Set");

            linkedlist.Set("0", 0);
            linkedlist.Set("1", 1);
            linkedlist.Set("2", 2);
            linkedlist.Set("6", 6);

            linkedlist.Traverse();

            Console.WriteLine("----------------------------------------- Insert");

            linkedlist.Insert("2222 inserted", 2);
            linkedlist.Traverse();

            Console.WriteLine("----------------------------------------- Remove");
            linkedlist.Remove(2);
            linkedlist.Remove(0);
            linkedlist.Remove(6);
            linkedlist.Remove(-1);
            linkedlist.Remove(15);
            linkedlist.Traverse();

            Console.WriteLine("----------------------------------------- Reverse");
            linkedlist.Reverse();
            linkedlist.Traverse();
        }
    }
}