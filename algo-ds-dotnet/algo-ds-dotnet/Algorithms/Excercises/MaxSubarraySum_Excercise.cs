using System;

namespace algo_ds_dotnet.Algorithms.Excercises
{
    public static class MaxSubarraySum_Excercise
    {
        public static void Run()
        {
            Console.WriteLine($"Thia should return 700: {MaxSubarraySum(new int[] { 100, 200, 300, 400 }, 2)}");
            Console.WriteLine($"Thia should return 39: {MaxSubarraySum(new int[] { 1, 4, 2, 10, 23, 3, 1, 0, 20 }, 4)}");
            Console.WriteLine($"Thia should return 5: {MaxSubarraySum(new int[] { -3, 4, 0, -2, 6, -1 }, 2)}");
            Console.WriteLine($"Thia should return 0: {MaxSubarraySum(new int[] { 2, 3 }, 3)}");
        }

        private static int MaxSubarraySum(int[] arr, int n)
        {
            if (arr.Length == 0) return 0;
            if (n > arr.Length) return 0;

            int max = 0;
            for (int i = 0; i < n; i++)
                max += arr[i];

            int temp = max;
            for (int i = n; i < arr.Length; i++)
            {
                temp = temp + arr[i] - arr[i - n];
                if (temp > max) max = temp;
            }
            return max;
        }
    }
}