using System;
using System.Collections.Generic;

namespace algo_ds_dotnet.Algorithms.Lesson4_MultiplePointers
{
    public static class ArrayCountUniqueValues
    {
        public static void Run()
        {
            //Console.WriteLine($"This should return 2: ==> {CountUniqueValues_FrequencyCounter(new int[] { 1, 1, 1, 1, 1, 2 })}"); // 2
            //Console.WriteLine($"This should return 7: ==> {CountUniqueValues_FrequencyCounter(new int[] { 1, 2, 3, 4, 4, 4, 7, 7, 12, 12, 13 })}"); // 7
            //Console.WriteLine($"This should return 0: ==> {CountUniqueValues_FrequencyCounter(new int[] { })}"); // 0
            //Console.WriteLine($"This should return 4: ==> {CountUniqueValues_FrequencyCounter(new int[] { -2, -1, -1, 0, 1 })}"); // 4



            Console.WriteLine($"This should return 2: ==> {CountUniqueValues_MultiplePointers(new int[] { 1, 1, 1, 1, 1, 2 })}"); // 2
            Console.WriteLine($"This should return 7: ==> {CountUniqueValues_MultiplePointers(new int[] { 1, 2, 3, 4, 4, 4, 7, 7, 12, 12, 13 })}"); // 7
            Console.WriteLine($"This should return 0: ==> {CountUniqueValues_MultiplePointers(new int[] { })}"); // 0
            Console.WriteLine($"This should return 4: ==> {CountUniqueValues_MultiplePointers(new int[] { -2, -1, -1, 0, 1 })}"); // 4
        }

        //Implement a function called countUniqueValues, which accepts a sorted array, and counts the unique values in the array.
        //There can be negative numbers in the array, but it will always be sorted.
        private static int CountUniqueValues_FrequencyCounter(int[] sortedArr) //O(n)
        {
            //<item, occurences>
            Dictionary<int, int> frequencyCounter = new Dictionary<int, int>();
            for (int i = 0; i < sortedArr.Length; i++)
                frequencyCounter[sortedArr[i]] = frequencyCounter.ContainsKey(sortedArr[i]) ? frequencyCounter[sortedArr[i]] + 1 : 1;

            return frequencyCounter.Count;
        }


        private static int CountUniqueValues_MultiplePointers(int[] sortedArr) //O(n)
        {
            if (sortedArr.Length == 0) return 0;

            int i = 0;
            for (int j = 1; j < sortedArr.Length; j++)
            {
                if (sortedArr[i] != sortedArr[j])
                {
                    i++;
                    sortedArr[i] = sortedArr[j];
                }
            }

            return i + 1;
        }
    }
}