using System;
using System.Linq;

namespace algo_ds_dotnet.Algorithms.Lesson6_Recursion.Excercises2
{
    public static class NestedEvenSum_Excercise
    {
        public static void Run()
        {
            Console.WriteLine($"This should return 12: => {NestedEvenSum(1, 2, 3, 4, 5, 6)}");
            Console.WriteLine($"This should return 22: => {NestedEvenSum(10, 2, 3, 4, 5, 6)}");
            Console.WriteLine($"This should return 66: => {NestedEvenSum(1, 2, 3, 4, 54, 6)}");
        }


        private static int NestedEvenSum(params int[] arr)
        {
            if (arr.Length == 0) return 0;

            return (arr[0] % 2 == 0 ? arr[0] : 0) + NestedEvenSum(arr.Skip(1).ToArray());
        }
    }
}