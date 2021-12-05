using System;

namespace algo_ds_dotnet.Algorithms.Excercises
{
    public static class AveragePair_Excercise
    {
        public static void Run()
        {
            Console.WriteLine($"This should return True: {AveragePair_MultiplePointers(new int[] { 1, 2, 3 }, 2.5m)}");
            Console.WriteLine($"This should return True: {AveragePair_MultiplePointers(new int[] { 1, 3, 3, 5, 6, 7, 10, 12, 19 }, 8)}");
            Console.WriteLine($"This should return False: {AveragePair_MultiplePointers(new int[] { -1, 0, 3, 4, 5, 6 }, 4.1m)}");
            Console.WriteLine($"This should return False: {AveragePair_MultiplePointers(new int[] { }, 4)}");
        }


        private static bool AveragePair_MultiplePointers(int[] sortedArr, decimal average)
        {
            if (sortedArr.Length == 0) return false;

            int left = 0;
            int right = sortedArr.Length - 1;

            while (left < right)
            {
                decimal avg = (decimal)(sortedArr[left] + sortedArr[right]) / 2;
                if (avg == average)
                    return true;
                else if (avg < average)
                    left++;
                else
                    right--;
            }
            return false;
        }
    }
}