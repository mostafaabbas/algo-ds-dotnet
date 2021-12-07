using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.Algorithms.Lesson7_Search
{
    public static class L1_LinearSearch
    {
        public static void Run()
        {
            Console.WriteLine($"4: ==> {LinearSearch(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5)}");
            Console.WriteLine($"3: ==> {LinearSearch(new int[] { 5, 6, 7, 8, 9 }, 8)}");
            Console.WriteLine($"-1: ==> {LinearSearch(new int[] { 5, 6, 7, 8, 9 }, 10)}");
        }


        private static int LinearSearch(int[] arr, int val)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == val)
                    return i;
            }
            return -1;
        }
    }
}