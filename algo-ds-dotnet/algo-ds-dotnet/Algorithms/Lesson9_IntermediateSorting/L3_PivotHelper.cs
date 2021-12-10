using algo_ds_dotnet.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.Algorithms.Lesson9_IntermediateSorting
{
    public static class L3_PivotHelper
    {
        public static void Run()
        {
            int[] arr = new int[] { 5, 9, 6, 3, 10, 15, 9, 4 };
            ArrayHelper.PrintArray(arr);

            int start = 5;
            Console.WriteLine(start);

            var result = Pivot(arr, start, arr.Length);

            ArrayHelper.PrintArray(arr);
            Console.WriteLine(result);
        }


        public static int Pivot(int[] arr, int start, int end)
        {
            int swap = 0;

            for (int i = start + 1; i <= end; i++)
            {
                if(arr[i] <= arr[start])
                {
                    swap++;
                    if(i != swap + 1)
                    {
                        var temp = arr[swap + start];
                        arr[swap + start] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            if(start != swap)
            {
                var temp = arr[swap + start];
                arr[swap + start] = arr[start];
                arr[start] = temp;
            }

            return swap + start;
        }
    }
}