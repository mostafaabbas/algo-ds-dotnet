using System;
using System.Collections.Generic;

namespace algo_ds_dotnet.Algorithms.Lesson2_Problems
{
    public static class StringEachCharsCount
    {
        public static void Run(string str)
        {
            foreach (var item in CharsCount(str))
                Console.WriteLine($"{item.Key} : {item.Value}");
        }

        //Write a function which takes in a string and returns counts of each character in the string.
        private static Dictionary<char, int> CharsCount(string str)
        {
            // define the result
            Dictionary<char, int> chars = new Dictionary<char, int>();

            //lowercase the string
            str = str.ToLower();

            // loop over the string chars
            foreach (var c in str)
            {
                if (chars.ContainsKey(c))
                    chars[c] += 1;
                else
                    chars.Add(c, 1);
            }

            // return the result
            return chars;
        }
    }
}