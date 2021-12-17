using System;

namespace algo_ds_dotnet.DataStructures.L6_HashTables
{
    public static class HashTables_Test
    {
        public static void Run()
        {
            //var arrLen = 31;
            //Console.WriteLine("********* Naive_1 **********************");
            //Console.WriteLine($"pink: => {NaiveHashing.NaiveHash_1("pink", arrLen)}");
            //Console.WriteLine($"red: => {NaiveHashing.NaiveHash_1("red", arrLen)}");
            //Console.WriteLine($"blue: => {NaiveHashing.NaiveHash_1("blue", arrLen)}");
            //Console.WriteLine($"cyan: => {NaiveHashing.NaiveHash_1("cyan", arrLen)}");
            //Console.WriteLine("********* Naive_2 **********************");
            //Console.WriteLine($"pink: => {NaiveHashing.NaiveHash_2("pink", arrLen)}");
            //Console.WriteLine($"red: => {NaiveHashing.NaiveHash_2("red", arrLen)}");
            //Console.WriteLine($"blue: => {NaiveHashing.NaiveHash_2("blue", arrLen)}");
            //Console.WriteLine($"cyan: => {NaiveHashing.NaiveHash_2("cyan", arrLen)}");

            CustomHashTable ht = new CustomHashTable(53);
            ht.Set("red", "#FF0000");
            ht.Set("blue", "#0000FF");
            ht.Set("yellow", "#FFFF00");
            ht.Set("black", "#000000");
            ht.Set("white", "#FFFFFF");

            Console.WriteLine($"red: FF0000 => {ht.Get("red")}");
            Console.WriteLine($"blue: 0000FF => {ht.Get("blue")}");
            Console.WriteLine($"yellow: FFFF00 => {ht.Get("yellow")}");
            Console.WriteLine($"black: 000000 => {ht.Get("black")}");
            Console.WriteLine($"white: FFFFFF => {ht.Get("white")}");

            Console.WriteLine("********* Keys-Values **********************");
            Console.WriteLine(string.Join(" -> ", ht.Keys));
            Console.WriteLine(string.Join(" -> ", ht.Values));
        }


    }
}