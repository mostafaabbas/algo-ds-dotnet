using System;
using System.Linq;

namespace algo_ds_dotnet.Algorithms.Lesson6_Recursion
{
    public static class ProductOfArray_Excercise
    {
        public static void Run()
        {
            Console.WriteLine($"This should return 6: => {ProductOfArray(1, 2, 3)}");
            Console.WriteLine($"This should return 60: => {ProductOfArray(1, 2, 3, 10)}");
        }


        private static int ProductOfArray(params int[] arr)
        {
            //base case
            if (arr.Length == 0) return 1;

            return arr[0] * ProductOfArray(arr.Skip(1).ToArray());
        }
    }
}