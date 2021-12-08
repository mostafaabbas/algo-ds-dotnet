using System;
using System.Linq;

namespace algo_ds_dotnet.Algorithms.Lesson7_Search
{
    public static class L2_BinarySearch_Recursively
    {
        public static void Run()
        {
            Console.WriteLine($"4: ==> {BinarySearch_Recursively(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5)}");
            Console.WriteLine($"3: ==> {BinarySearch_Recursively(new int[] { 5, 6, 7, 8, 9 }, 8)}");
            Console.WriteLine($"-1: ==> {BinarySearch_Recursively(new int[] { 5, 6, 7, 8, 9 }, 10)}");
        }


        private static int BinarySearch_Recursively(int[] sortedArr, int val)
        {
            return -1;
        }
    }
}