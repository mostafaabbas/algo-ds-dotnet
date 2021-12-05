using System;

namespace algo_ds_dotnet.Algorithms.Lesson4_MultiplePointers
{
    public static class MultiplePointers_ArraySumZero
    {
        public static void Run()
        {
            //var t1 = SumZero_Naive(new int[] { -3, -2, -1, 0, 1, 2, 3 });
            //Console.WriteLine($"This should return 3-,3 ==> [{t1.Item1}, {t1.Item2}]");

            //var t2 = SumZero_Naive(new int[] { -2, 0, 1, 3 });
            //Console.WriteLine($"This should return null ==> [{t2.Item1}, {t2.Item2}]");

            //var t3 = SumZero_Naive(new int[] { 1, 2, 3 });
            //Console.WriteLine($"This should return null ==> [{t3.Item1}, {t3.Item2}]");



            var t1 = SumZero_BeginingEndPointers(new int[] { -3, -2, -1, 0, 1, 2, 3 });
            Console.WriteLine($"This should return 3-,3 ==> [{t1.Item1}, {t1.Item2}]");

            var t2 = SumZero_BeginingEndPointers(new int[] { -2, 0, 1, 3 });
            Console.WriteLine($"This should return null ==> [{t2.Item1}, {t2.Item2}]");

            var t3 = SumZero_BeginingEndPointers(new int[] { 1, 2, 3 });
            Console.WriteLine($"This should return null ==> [{t3.Item1}, {t3.Item2}]");
        }

        //Write a function called sumZero which accepts a sorted array of integers.
        //The function should find the first pair where the sum is 0.
        //Return an array that includes both values that sum to zero or undefined if a pair does not exist
        private static Tuple<int, int> SumZero_Naive(int[] sortedArr)  //O(n^2) nested loop
        {
            for (int i = 0; i < sortedArr.Length; i++)
            {
                for (int j = i + 1; j < sortedArr.Length; j++)
                {
                    if (sortedArr[i] + sortedArr[j] == 0)
                        return new Tuple<int, int>(sortedArr[i], sortedArr[j]);
                }
            }

            return new Tuple<int, int>(0, 0);
        }

        private static Tuple<int, int> SumZero_BeginingEndPointers(int[] sortedArr) //O(n) multiple pointers
        {
            int left = 0;
            int right = sortedArr.Length - 1;

            while (left < right)
            {
                int sum = sortedArr[left] + sortedArr[right];
                if (sum == 0)
                    return new Tuple<int, int>(sortedArr[left], sortedArr[right]);
                else if (sum < 0)
                    left++;
                else
                    right--;
            }

            return new Tuple<int, int>(0, 0);
        }
    }
}