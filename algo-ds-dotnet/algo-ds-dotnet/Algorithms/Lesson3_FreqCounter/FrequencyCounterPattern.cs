using System;
using System.Collections.Generic;

namespace algo_ds_dotnet.Algorithms.Lesson3_FreqCounter
{
    public static class FrequencyCounterPattern
    {
        public static void Run()
        {
            var result_1 = Same_1(new int[] { 1, 2, 3 }, new int[] { 9, 1, 4 });
            var result_2 = Same_1(new int[] { 1, 2, 1 }, new int[] { 4, 1, 4 });
            var result_3 = Same_1(new int[] { 1, 2, 3 }, new int[] { 9, 1, 4, 5 });
            var result_4 = Same_1(new int[] { 1, 2, 3, 2 }, new int[] { 9, 1, 4, 4 });

            Console.WriteLine($"result_1 should equal True ==> {result_1}");
            Console.WriteLine($"result_2 should equal False ==> {result_2}");
            Console.WriteLine($"result_3 should equal False ==> {result_3}");
            Console.WriteLine($"result_4 should equal True ==> {result_4}");


            Console.WriteLine("----------------------------------------------------------");

            var result_5 = Same_2(new int[] { 1, 2, 3 }, new int[] { 9, 1, 4 });
            var result_6 = Same_2(new int[] { 1, 2, 1 }, new int[] { 4, 1, 4 });
            var result_7 = Same_2(new int[] { 1, 2, 3 }, new int[] { 9, 1, 4, 5 });
            var result_8 = Same_2(new int[] { 1, 2, 3, 2 }, new int[] { 9, 1, 4, 4 });

            Console.WriteLine($"result_5 should equal True ==> {result_5}");
            Console.WriteLine($"result_6 should equal False ==> {result_6}");
            Console.WriteLine($"result_7 should equal False ==> {result_7}");
            Console.WriteLine($"result_8 should equal True ==> {result_8}");
        }


        //Write a function called same, which accepts two arrays.
        //The function should return true if every value in the array has it's corresponding value squared in the second array.
        //The frequency of values must be the same.
        private static bool Same_1(int[] arr1, int[] arr2)  //O(n^2) nested loop - naive solution
        {
            if (arr1.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                var index = Array.IndexOf(arr2, arr1[i] * arr1[i]);
                if (index < 0)
                    return false;

                var list = new List<int>(arr2);
                list.RemoveAt(index);
                arr2 = list.ToArray();
            }

            return true;
        }


        private static bool Same_2(int[] arr1, int[] arr2)  //O(n) no nested loops - perfect solution - frequency counter pattern
        {
            if (arr1.Length != arr2.Length)
                return false;

            //<value, count>
            Dictionary<int, int> frequencyCounter1 = new Dictionary<int, int>();
            foreach (var item in arr1)
                frequencyCounter1[item] = frequencyCounter1.ContainsKey(item) ? frequencyCounter1[item] + 1 : 1;
            //<value, count>
            Dictionary<int, int> frequencyCounter2 = new Dictionary<int, int>();
            foreach (var item in arr2)
                frequencyCounter2[item] = frequencyCounter2.ContainsKey(item) ? frequencyCounter2[item] + 1 : 1;

            foreach (var kvp1 in frequencyCounter1)
            {
                if (frequencyCounter2.ContainsKey(kvp1.Key * kvp1.Key) == false)
                    return false;

                if (frequencyCounter2[kvp1.Key * kvp1.Key] != kvp1.Value)
                    return false;
            }

            return true;
        }
    }
}
