using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.Algorithms.Lesson6_Recursion
{
    public static class RecursionSimpleExample
    {
        public static void Run()
        {
            CountDown(5);

            int num = 16000;
            Console.WriteLine("----------------------------------------");

            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine($"This should print 15: ==> {SumRange(num)}");
            sw.Stop();
            Console.WriteLine($"took: {sw.ElapsedMilliseconds} ms");

            Console.WriteLine("----------------------------------------");

            sw.Restart();
            Console.WriteLine($"This should print 15: ==> {SumRange_NoRecursion(num)}");
            sw.Stop();
            Console.WriteLine($"took: {sw.ElapsedMilliseconds} ms");
        }

        //print the numbers to 1
        private static void CountDown(int num)
        {
            Console.WriteLine($"Num: {num}");

            num--; //different input
            if (num > 0)
                CountDown(num); //different input
            else //base case
                Console.WriteLine("All done"); //base case
        }


        private static long SumRange(int num)
        {
            //base case
            if (num <= 1)
                return 1;

            return num + SumRange(num - 1);
        }

        private static long SumRange_NoRecursion(int num)
        {
            long sum = 0;
            for (int i = 0; i <= num; i++)
                sum += i;
            return sum;
        }
    }
}