using System;
using System.Collections.Generic;

namespace algo_ds_dotnet.Algorithms.Lesson3_FreqCounter
{
    public static class StringAnagram
    {
        public static void Run()
        {
            //Console.WriteLine($"This Should be True: {ValidAnagram_1("", "")}");// true
            //Console.WriteLine($"This Should be False: {ValidAnagram_1("aaz", "zza")}"); // false
            //Console.WriteLine($"This Should be True: {ValidAnagram_1("anagram", "nagaram")}"); // true
            //Console.WriteLine($"This Should be False: {ValidAnagram_1("rat", "car")}"); // false
            //Console.WriteLine($"This Should be False: {ValidAnagram_1("awesome", "awesom")}"); // false
            //Console.WriteLine($"This Should be True: {ValidAnagram_1("qwerty", "qeywrt")}"); // true
            //Console.WriteLine($"This Should be True: {ValidAnagram_1("texttwisttime", "timetwisttext")}"); // true

            Console.WriteLine($"This Should be True: {ValidAnagram_2("", "")}");// true
            Console.WriteLine($"This Should be False: {ValidAnagram_2("aaz", "zza")}"); // false
            Console.WriteLine($"This Should be True: {ValidAnagram_2("anagram", "nagaram")}"); // true
            Console.WriteLine($"This Should be False: {ValidAnagram_2("rat", "car")}"); // false
            Console.WriteLine($"This Should be False: {ValidAnagram_2("awesome", "awesom")}"); // false
            Console.WriteLine($"This Should be True: {ValidAnagram_2("qwerty", "qeywrt")}"); // true
            Console.WriteLine($"This Should be True: {ValidAnagram_2("texttwisttime", "timetwisttext")}"); // true
        }


        //Given two strings, write a function to determine if the second string is an anagram of the first.
        //An anagram is a word, phrase, or name formed by rearranging the letters of another,
        //such as cinema, formed from iceman.
        private static bool ValidAnagram_1(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

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

        private static bool ValidAnagram_2(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            //<char, occurences>
            Dictionary<char, int> frequencyCounter1 = new Dictionary<char, int>();
            foreach (var c in str1)
                frequencyCounter1[c] = frequencyCounter1.ContainsKey(c) ? frequencyCounter1[c] + 1 : 1;


            foreach (var c in str2)
            {
                if (frequencyCounter1.ContainsKey(c) == false || frequencyCounter1[c] == 0)
                    return false;
                frequencyCounter1[c]--;
            }

            return true;
        }
    }
}
