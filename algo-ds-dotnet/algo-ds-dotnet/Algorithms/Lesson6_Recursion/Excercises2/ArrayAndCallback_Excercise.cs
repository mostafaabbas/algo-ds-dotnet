using System;
using System.Linq;

namespace algo_ds_dotnet.Algorithms.Lesson6_Recursion.Excercises2
{
    public static class ArrayAndCallback_Excercise
    {
        public static void Run()
        {
            Console.WriteLine($"This should return true: ==> {SomeRecursive(new int[] { 1, 2, 3, 4 }, IsOdd)}");
            Console.WriteLine($"This should return true: ==> {SomeRecursive(new int[] { 4, 6, 8, 9 }, IsOdd)}");
            Console.WriteLine($"This should return false: ==> {SomeRecursive(new int[] { 4, 6, 8 }, IsOdd)}");
            Console.WriteLine($"This should return false: ==> {SomeRecursive(new int[] { 4, 6, 8 }, x => x > 10)}");
        }


        private static bool SomeRecursive(int[] arr, Func<int, bool> callback)
        {
            if (arr.Length == 0) return false;

            if (callback(arr[0])) return true;

            return SomeRecursive(arr.Skip(1).ToArray(), callback);
        }

        private static bool IsOdd(int num)
        {
            return num % 2 == 1;
        }
    }
}