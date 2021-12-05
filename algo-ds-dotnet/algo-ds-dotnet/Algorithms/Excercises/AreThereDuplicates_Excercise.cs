using System;
using System.Collections.Generic;
using System.Linq;

namespace algo_ds_dotnet.Algorithms.Excercises
{
    public static class AreThereDuplicates_Excercise
    {
        public static void Run()
        {
            Console.WriteLine($"This Should return False: {AreThereDuplicates_FrequencyCounter(1, 2, 3)}");
            Console.WriteLine($"This Should return True: {AreThereDuplicates_FrequencyCounter(1, 2, 2)}");

            Console.WriteLine($"This Should return False: {AreThereDuplicates_MultiplePointers(1, 2, 3)}");
            Console.WriteLine($"This Should return True: {AreThereDuplicates_MultiplePointers(1, 2, 2)}");
        }

        private static bool AreThereDuplicates_FrequencyCounter(params int[] arr)
        {
            if (arr.Length == 0) return false;

            //<item, occuences>
            Dictionary<int, int> frequencyCounter = new Dictionary<int, int>();
            foreach (var item in arr)
                frequencyCounter[item] = frequencyCounter.ContainsKey(item) ? frequencyCounter[item] + 1 : 1;

            return frequencyCounter.Count(c => c.Value > 1) > 0;
        }

        private static bool AreThereDuplicates_MultiplePointers(params int[] arr)
        {
            if (arr.Length == 0) return false;

            //sort: because this solution needs a sorted array
            arr = arr.OrderBy(c => c).ToArray();

            int i = 0;
            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                    return true;
                i++;
            }
            return false;
        }
    }
}