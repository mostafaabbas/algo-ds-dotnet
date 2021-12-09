using algo_ds_dotnet.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.Algorithms.Lesson9_IntermediateSorting
{
    public static class L1_MergingArrays
    {
        public static void Run()
        {
            ArrayHelper.PrintArray(Merge(new int[] { 1, 3, 9 }, new int[] { 0, 2, 4, 7, 10 }));
            ArrayHelper.PrintArray(Merge(new int[] { }, new int[] { 5, 9 }));
            ArrayHelper.PrintArray(Merge(new int[] { 55, 77, 99 }, new int[] { 12, 54, 66, 99 }));
        }


        private static int[] Merge(int[] arr1, int[] arr2) //two sorted arrays
        {
            int[] newArr = new int[arr1.Length + arr2.Length];
            int index1 = 0, index2 = 0;

            while (index1 < arr1.Length && index2 < arr2.Length)
            {
                if(arr1[index1] < arr2[index2])
                {
                    newArr[index1 + index2] = arr1[index1];
                    index1++;
                }
                else
                {
                    newArr[index1 + index2] = arr2[index2];
                    index2++;
                }
            }
            while (index1 < arr1.Length)
            {
                newArr[index1 + index2] = arr1[index1];
                index1++;
            }
            while (index2 < arr2.Length)
            {
                newArr[index1 + index2] = arr2[index2];
                index2++;
            }


            return newArr;
        }
    }
}