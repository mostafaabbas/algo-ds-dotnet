using algo_ds_dotnet.Helpers;
using System;
using System.Linq;

namespace algo_ds_dotnet.Algorithms.Lesson9_IntermediateSorting
{
    public static class L2_MergeSort
    {
        public static void Run()
        {
            ArrayHelper.PrintArray(MergeSort(new int[] { 1, 3, 9, 0, 2, 4, 7, 10 }));
            ArrayHelper.PrintArray(MergeSort(new int[] { 100, 5, 9 }));
            ArrayHelper.PrintArray(MergeSort(new int[] { 55, 77, 99, 12, 54, 66, 99 }));
        }

        private static int[] MergeSort(int[] arr)
        {
            //base case
            if (arr.Length <= 1) return arr;

            int mid = (int)Math.Floor((decimal)arr.Length / 2);

            var left = MergeSort(arr.Take(mid).ToArray());
            var right = MergeSort(arr.Skip(mid).Take(mid + 1).ToArray());
            return L1_MergingArrays.MergeSortedArrays(left, right);
        }
    }
}