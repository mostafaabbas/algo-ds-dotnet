using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.Algorithms.Lesson9_IntermediateSorting
{
    public static class L5_RadixHelper
    {
        public static void Run()
        {
            Console.WriteLine($"This should return 5: {GetDigit(98563, 2)}");
            Console.WriteLine($"This should return 3: {GetDigit(98563, 0)}");
            Console.WriteLine($"This should return 9: {GetDigit(98563, 4)}");
            Console.WriteLine($"This should return 0: {GetDigit(98563, 5)}");

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine($"This should return 5: {GetDigitsCount(98563)}");
            Console.WriteLine($"This should return 4: {GetDigitsCount(9856)}");
            Console.WriteLine($"This should return 1: {GetDigitsCount(1)}");
            Console.WriteLine($"This should return 9: {GetDigitsCount(975863346)}");

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine($"This should return 4: {GetMostDigits(new int[] { 55, 0, 698, 6598, 33, 6, 4569 })}");
        }


        public static int GetDigit(int num, int index)
        {
            return (int)Math.Floor(Math.Abs(num) / Math.Pow(10, index)) % 10;
        }

        public static int GetDigitsCount(int num)
        {
            if (num == 0) return 1;
            return (int)Math.Floor(Math.Log10(Math.Abs(num))) + 1;
        }

        public static int GetMostDigits(int[] arr)
        {
            var maxDigits = 0;

            for (var i = 0; i < arr.Length; i++)
                maxDigits = Math.Max(maxDigits, GetDigitsCount(arr[i]));

            return maxDigits;
        }
    }
}