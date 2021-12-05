using System;
using System.Collections.Generic;

namespace algo_ds_dotnet.Algorithms.Excercises
{
    public static class SameFrequency_Excercise
    {
        public static void Run()
        {
            Console.WriteLine($"This should return True: {SameFrequency(182, 281)}");
            Console.WriteLine($"This should return False: {SameFrequency(34, 14)}");
            Console.WriteLine($"This should return True: {SameFrequency(3589578, 5879385)}");
            Console.WriteLine($"This should return False: {SameFrequency(22, 222)}");
        }


        private static bool SameFrequency(int num1, int num2)
        {
            string str1 = num1.ToString();
            string str2 = num2.ToString();

            //<char, occurences>
            Dictionary<char, int> frequencyCounter1 = new Dictionary<char, int>();
            foreach (var c in str1)
                frequencyCounter1[c] = frequencyCounter1.ContainsKey(c) ? frequencyCounter1[c] + 1 : 1;

            //<char, occurences>
            Dictionary<char, int> frequencyCounter2 = new Dictionary<char, int>();
            foreach (var c in str2)
                frequencyCounter2[c] = frequencyCounter2.ContainsKey(c) ? frequencyCounter2[c] + 1 : 1;

            foreach (var kvp in frequencyCounter1)
            {
                if (frequencyCounter2.ContainsKey(kvp.Key) == false)
                    return false;
                if (frequencyCounter2[kvp.Key] != kvp.Value)
                    return false;
            }

            return true;
        }
    }
}