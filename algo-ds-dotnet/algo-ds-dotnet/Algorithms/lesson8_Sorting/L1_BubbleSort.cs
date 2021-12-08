using algo_ds_dotnet.Helpers;

namespace algo_ds_dotnet.Algorithms.lesson8_Sorting
{
    public static class L1_BubbleSort
    {
        public static void Run()
        {
            ArrayHelper.PrintArray(BubbleSort(new int[] { 5, 3, 1, 9, 4, 6 }));
            ArrayHelper.PrintArray(BubbleSort(new int[] { 8, 1, 2, 3, 4, 5, 6, 7 }));
        }


        private static int[] BubbleSort(int[] arr)
        {
            int arrLength = arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                bool noSwaps = true;
                for (int j = 0; j < arrLength - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        noSwaps = false;
                    }
                }
                arrLength--;
                if (noSwaps) break;
            }

            return arr;
        }
    }
}