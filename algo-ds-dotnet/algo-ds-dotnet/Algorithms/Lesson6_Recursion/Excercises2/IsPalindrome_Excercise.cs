using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.Algorithms.Lesson6_Recursion.Excercises2
{
    public static class IsPalindrome_Excercise
    {
        public static void Run()
        {
            Console.WriteLine($"This should false: ==> {IsPalindrome("awesome")}");
            Console.WriteLine($"This should false: ==> {IsPalindrome("foobar")}");
            Console.WriteLine($"This should true: ==> {IsPalindrome("tacocat")}");
            Console.WriteLine($"This should true: ==> {IsPalindrome("amanaplanacanalpanama")}");
            Console.WriteLine($"This should false: ==> {IsPalindrome("amanaplanacanalpandemonium")}");
        }


        private static bool IsPalindrome(string str)
        {
            if (str.Length < 2)
                return true;

            if (str[0] != str[str.Length - 1])
                return false;

            str = str.Remove(0, 1);
            str = str.Remove(str.Length - 1);
            return IsPalindrome(str);
        }
    }
}