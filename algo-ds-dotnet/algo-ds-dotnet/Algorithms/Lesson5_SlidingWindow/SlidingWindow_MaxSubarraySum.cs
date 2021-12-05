using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.Algorithms.Lesson5_SlidingWindow
{
    public static class SlidingWindow_MaxSubarraySum
    {
        public static void Run()
        {
            //Console.WriteLine($"This should be 10: => {MaxSubarraySum_Naive(new int[] { 1, 2, 5, 2, 8, 1, 5 }, 2)}"); // 10
            //Console.WriteLine($"This should be 17: => {MaxSubarraySum_Naive(new int[] { 1, 2, 5, 2, 8, 1, 5 }, 4)}"); // 17
            //Console.WriteLine($"This should be 6: => {MaxSubarraySum_Naive(new int[] { 4, 2, 1, 6 }, 1)}"); // 6
            //Console.WriteLine($"This should be 13: => {MaxSubarraySum_Naive(new int[] { 4, 2, 1, 6, 2 }, 4)}"); // 13
            //Console.WriteLine($"This should be 0: => {MaxSubarraySum_Naive(new int[] { }, 4)}"); // null

            Console.WriteLine($"This should be 10: => {MaxSubarraySum_SlidingWindow(new int[] { 1, 2, 5, 2, 8, 1, 5 }, 2)}"); // 10
            Console.WriteLine($"This should be 17: => {MaxSubarraySum_SlidingWindow(new int[] { 1, 2, 5, 2, 8, 1, 5 }, 4)}"); // 17
            Console.WriteLine($"This should be 6: => {MaxSubarraySum_SlidingWindow(new int[] { 4, 2, 1, 6 }, 1)}"); // 6
            Console.WriteLine($"This should be 13: => {MaxSubarraySum_SlidingWindow(new int[] { 4, 2, 1, 6, 2 }, 4)}"); // 13
            Console.WriteLine($"This should be 0: => {MaxSubarraySum_SlidingWindow(new int[] { }, 4)}"); // null
        }


        //Write a function called maxSubarraySum which accepts an array of integers and a number called n.
        //The function should calculate the maximum sum of n consecutive elements in the array.
        private static int MaxSubarraySum_Naive(int[] arr, int n) //nested loop
        {
            if (n > arr.Length) return 0;

            int max = -1;
            for (int i = 0; i < arr.Length - n + 1; i++)
            {
                int temp = 0;
                for (int j = i; j < n + i; j++)
                {
                    temp += arr[j];
                }
                if (temp > max)
                    max = temp;
            }

            return max;
        }


        private static int MaxSubarraySum_SlidingWindow(int[] arr, int n) //O(n)
        {
            if (n > arr.Length) return 0;

            int max = 0;
            for (int i = 0; i < n; i++)
                max += arr[i];

            int temp = max;
            for (int i = n; i < arr.Length; i++)
            {
                temp = temp - arr[i - n] + arr[i];
                max = temp > max ? temp : max;
            }
            return max;
        }
    }
}