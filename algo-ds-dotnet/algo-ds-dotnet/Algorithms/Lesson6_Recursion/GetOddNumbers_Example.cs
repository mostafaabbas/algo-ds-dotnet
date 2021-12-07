using algo_ds_dotnet.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.Algorithms.Lesson6_Recursion
{
    public static class GetOddNumbers_Example
    {
        public static void Run()
        {
            ArrayHelper.PrintArray(GetOddNumbers(new int[] { 1, 2, 3, 4, 5, 6, 7, 9 }));
            ArrayHelper.PrintArray(GetOddNumbers(new int[] { 99, 56, 65, 47, 48, 49, 22 }));
        }

        private static int[] GetOddNumbers(int[] arr)
        {
            int[] newArr = new int[1];

            //base case
            if (arr.Length == 0)
                return newArr;

            if (arr[0] % 2 == 1)
                newArr[0] = arr[0];
            else
                newArr = new int[] { };

            newArr = newArr.Concat(GetOddNumbers(arr.Skip(1).ToArray())).ToArray(); //different input
            return newArr;
        }
    }
}
