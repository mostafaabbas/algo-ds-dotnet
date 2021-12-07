using System;

namespace algo_ds_dotnet.Algorithms.Lesson6_Recursion.Excercises2
{
    public static class ReverseString_Excercise
    {
        public static void Run()
        {
            Console.WriteLine($"This should return olleH: ==> :{Reverse("Hello")}");
            Console.WriteLine($"This should return emosewa: ==> :{Reverse("awesome")}");
            Console.WriteLine($"This should return loohcsmhtir: ==> :{Reverse("rithmschool")}");
        }


        private static string Reverse(string str)
        {
            if (str.Length == 0) return "";

            return str[str.Length - 1] + Reverse(str.Remove(str.Length - 1));
        }
    }
}