using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.Algorithms.Lesson10_DynamicProgramming
{
    public static class Fibonacci_Dynamic
    {
        public static void Run()
        {
            int num = 45;

            Stopwatch sw = Stopwatch.StartNew();
            var f1 = Fib(num);
            sw.Stop();
            Console.WriteLine($"Fib({num}): {f1}: took: {sw.ElapsedMilliseconds}");

            sw.Restart();
            var ft = Fib_Dynamic_TABULATION(num);
            sw.Stop();
            Console.WriteLine($"Fib_Dynamic TABULATION({num}): {ft}: took: {sw.ElapsedMilliseconds}");


            sw.Restart();
            var f2 = Fib_Dynamic_Memoization(num);
            sw.Stop();
            Console.WriteLine($"Fib_Dynamic Memoization({num}): {f2}: took: {sw.ElapsedMilliseconds}");

            sw.Restart();
            var f3 = Fib_Dynamic_Memoization(num);
            sw.Stop();
            Console.WriteLine($"Fib_Dynamic Memoization({num}): {f3}: took: {sw.ElapsedMilliseconds}");
        }



        public static int Fib(int num)
        {
            if (num <= 2) return 1;
            return Fib(num - 1) + Fib(num - 2);
        }


        public static Dictionary<int, int> Fib_Results = new Dictionary<int, int>();

        public static int Fib_Dynamic_Memoization(int num) //from up down
        {
            if (num <= 2) return 1;

            int fib1, fib2;

            //n - 1
            if (Fib_Results.ContainsKey(num - 1))
                fib1 = Fib_Results[num - 1];
            else
            {
                fib1 = Fib(num - 1);
                Fib_Results[num - 1] = fib1;
            }
            //n - 2
            if (Fib_Results.ContainsKey(num - 2))
                fib2 = Fib_Results[num - 2];
            else
            {
                fib2 = Fib(num - 2);
                Fib_Results[num - 2] = fib2;
            }

            return fib1 + fib2;
        }

        public static int Fib_Dynamic_TABULATION(int num) //from bottom up
        {
            if (num <= 2) return 1;
            
            List<int> nums = new() { 0, 1, 1 };
            for (int i = 3; i <= num; i++)
            {
                nums.Add(nums[i - 1] + nums[i - 2]);
            }

            return nums[num];
        }
    }
}
