using algo_ds_dotnet.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.Algorithms.Lesson9_IntermediateSorting
{
    public static class L4_QuickSort
    {
        public static void Run()
        {
            ArrayHelper.PrintArray(QuickSort(new int[] { 5, 9, 6, 3, 10, 15, 9, 4 }));
        }


        public static int[] QuickSort(int[] arr)
        {
            var start = 0;
            var end = L3_PivotHelper.Pivot(arr, start, arr.Length - 1);
            for (int i = 0; i < end - 1; i++)
            {
                L3_PivotHelper.Pivot(arr, i, end - 1);
            }
            for (int i = end + 1; i < arr.Length; i++)
            {
                L3_PivotHelper.Pivot(arr, i, arr.Length - 1);
            }
            return arr;
        }
    }
}