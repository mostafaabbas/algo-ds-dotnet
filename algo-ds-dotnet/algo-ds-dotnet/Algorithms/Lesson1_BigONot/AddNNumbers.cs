using System;
using System.Diagnostics;

namespace algo_ds_dotnet.Algorithms.Lesson1_BigONot
{
    public static class AddNNumbers
    {
        public static void AddNNumbersTest()
        {
            int n = 1000000000;

            Stopwatch sw = Stopwatch.StartNew();
            Add_N_Numbers_1(n);
            sw.Stop();
            Console.WriteLine($"Adding n Numbers in loop took: {sw.ElapsedMilliseconds}, Big O Notation => O(n)");

            sw.Restart();
            Add_N_Numbers_2(n);
            sw.Stop();
            Console.WriteLine($"Adding n Numbers in equation: {sw.ElapsedMilliseconds}, Big O Notation => O(1)");
        }


        //Big O Notation => O(n)
        public static long Add_N_Numbers_1(int n)
        {
            long l = 0;
            for (int i = 1; i < n - 1; i++)
            {
                l += i;
            }
            return l;
        }

        //Big O Notation => O(1)
        public static long Add_N_Numbers_2(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}