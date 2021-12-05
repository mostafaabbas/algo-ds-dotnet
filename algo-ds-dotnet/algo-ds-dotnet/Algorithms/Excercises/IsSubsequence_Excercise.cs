using System;

namespace algo_ds_dotnet.Algorithms.Excercises
{
    public static class IsSubsequence_Excercise
    {
        public static void Run()
        {
            Console.WriteLine($"This should return True: {IsSubsequence("hello", "hello world")}");
            Console.WriteLine($"This should return True: {IsSubsequence("sing", "sting")}");
            Console.WriteLine($"This should return True: {IsSubsequence("abc", "abracadabra")}");
            Console.WriteLine($"This should return False: {IsSubsequence("abc", "acb")}");
        }


        private static bool IsSubsequence(string str1, string str2)
        {
            int i = 0;

            foreach (var c in str2)
            {
                if (c == str1[i]) i++;
                if (i == str1.Length) return true;
            }
            return false;
        }
    }
}