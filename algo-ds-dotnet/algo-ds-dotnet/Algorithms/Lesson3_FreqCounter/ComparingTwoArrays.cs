using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.Algorithms.Lesson3_FreqCounter
{
    public static class ComparingTwoArrays
    {
        public static void Run()
        {
            var result_1 = Same_1(new int[] { 1, 2, 3 }, new int[] { 9, 1, 4 });
            var result_2 = Same_1(new int[] { 1, 2, 1 }, new int[] { 4, 1, 4 });
            var result_3 = Same_1(new int[] { 1, 2, 3 }, new int[] { 9, 1, 4, 5 });

            Console.WriteLine($"result_1 should equal True ==> {result_1}");
            Console.WriteLine($"result_2 should equal False ==> {result_2}");
            Console.WriteLine($"result_3 should equal False ==> {result_3}");
        }


        //Write a function called same, which accepts two arrays.
        //The function should return true if every value in the array has it's corresponding value squared in the second array.
        //The frequency of values must be the same.
        private static bool Same_1(int[] arr1, int[] arr2)
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
    }
}
