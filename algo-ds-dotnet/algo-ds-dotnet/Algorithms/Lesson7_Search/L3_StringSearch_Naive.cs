using System;

namespace algo_ds_dotnet.Algorithms.Lesson7_Search
{
    public static class L3_StringSearch_Naive
    {
        public static void Run()
        {
            Console.WriteLine($"This should return 1: {StringSearch("lorie loled", "lol")}");
            Console.WriteLine($"This should return 2: {StringSearch("wowomgzomg", "omg")}");
        }


        private static int StringSearch(string str, string pattern)
        {
            if (pattern.Length > str.Length) return 0;

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (str[i + j] != pattern[j])
                        break;
                    if (j == pattern.Length - 1)
                        count++;
                }
            }

            return count;
        }
    }
}