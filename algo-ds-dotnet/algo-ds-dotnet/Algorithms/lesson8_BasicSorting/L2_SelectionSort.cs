using algo_ds_dotnet.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.Algorithms.Lesson8_BasicSorting
{
    public static class L2_SelectionSort
    {
        public static void Run()
        {
            ArrayHelper.PrintArray(SelectionSort(new int[] { 5, 3, 1, 9, 4, 6 }));
            ArrayHelper.PrintArray(SelectionSort(new int[] { 8, 1, 2, 3, 4, 5, 6, 7 }));
        }


        private static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }

                if(minIndex != i)
                {
                    var temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }

            return arr;
        }
    }
}