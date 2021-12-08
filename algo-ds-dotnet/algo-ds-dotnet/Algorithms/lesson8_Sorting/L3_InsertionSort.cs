using algo_ds_dotnet.Helpers;

namespace algo_ds_dotnet.Algorithms.lesson8_Sorting
{
    public static class L3_InsertionSort
    {
        public static void Run()
        {
            ArrayHelper.PrintArray(InsertionSort(new int[] { 5, 3, 1, 9, 4, 6 }));
            ArrayHelper.PrintArray(InsertionSort(new int[] { 8, 1, 2, 3, 4, 5, 6, 7 }));
        }


        private static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int index = i;

                for (int j = index - 1; j >= 0; j--)
                {
                    if (arr[index] < arr[j])
                    {
                        var temp = arr[index];
                        arr[index] = arr[j];
                        arr[j] = temp;
                        index = j;
                    }
                }
            }

            return arr;
        }
    }
}