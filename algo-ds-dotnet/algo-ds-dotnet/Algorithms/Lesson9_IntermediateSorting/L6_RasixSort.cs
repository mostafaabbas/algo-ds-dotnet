using algo_ds_dotnet.Helpers;
using System;
using System.Linq;

namespace algo_ds_dotnet.Algorithms.Lesson9_IntermediateSorting
{
    public static class L6_RasixSort
    {
        public static void Run()
        {
            var arr = new int[] { 55, 5, 698, 6598, 33, 6, 4569, 666 };
            RadixSort(arr);
            ArrayHelper.PrintArray(arr);
        }


        private static void RadixSort(int[] arr)
        {
            var loops = L5_RadixHelper.GetMostDigits(arr);

            for (int i = 0; i < loops; i++)
            {
                int[][] buckets = new int[10][];
                for (int h = 0; h < buckets.Length; h++) buckets[h] = Array.Empty<int>();

                for (int j = 0; j < arr.Length; j++)
                {
                    var index = L5_RadixHelper.GetDigit(arr[j], i);
                    buckets[index] = buckets[index].Concat(new int[] { arr[j] }).ToArray();
                }

                int newArrInd = 0;
                for (int k = 0; k < buckets.Length; k++)
                {
                    for (int l = 0; l < buckets[k].Length; l++)
                    {
                        //arr = new int[] { arr.Length };
                        arr[newArrInd] = buckets[k][l];
                        newArrInd++;
                    }
                }
            }
        }
    }
}