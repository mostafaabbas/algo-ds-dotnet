using System;

namespace algo_ds_dotnet.Algorithms.Lesson7_Search
{
    public static class L2_BinarySearch
    {
        public static void Run()
        {
            Console.WriteLine($"4: ==> {BinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5)}");
            Console.WriteLine($"3: ==> {BinarySearch(new int[] { 5, 6, 7, 8, 9 }, 8)}");
            Console.WriteLine($"-1: ==> {BinarySearch(new int[] { 5, 6, 7, 8, 9 }, 10)}");
        }


        private static int BinarySearch(int[] sortedArr, int val)
        {
            int left = 0;
            int right = sortedArr.Length - 1;
            int middle = (left + right) / 2;

            while (sortedArr[middle] != val && left < right)
            {
                if (sortedArr[middle] > val)
                    right = middle - 1;
                else if (sortedArr[middle] < val)
                    left = middle + 1;

                middle = (left + right) / 2;
            }

            if (sortedArr[middle] == val)
                return middle;
            return -1;
        }
    }
}