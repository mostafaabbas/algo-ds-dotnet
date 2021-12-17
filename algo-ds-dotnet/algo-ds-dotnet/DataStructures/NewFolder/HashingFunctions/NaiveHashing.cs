using System;

namespace algo_ds_dotnet.DataStructures.NewFolder.HashingFunctions
{
    public static class NaiveHashing
    {
        //problems:
            //Only hashes strings
            //Not constant time - linear in key length
            //Could be a little more random
        public static int NaiveHash_1(string key, int arrayLength)
        {
            var total = 0;
            foreach (var c in key)
            {
                // map "a" to 1, "b" to 2, "c" to 3, etc.
                var value = (int)c - 96;
                total = (total + value) % arrayLength;
            }
            return total;
        }

        public static int NaiveHash_2(string key, int arrayLength)
        {
            var total = 0;
            var WEIRD_PRIME = 31;
            for (var i = 0; i < Math.Min(key.Length, 100); i++) //math.min to be constant time
            {
                var c = key[i];
                var value = (int)c - 96;
                total = (total * WEIRD_PRIME + value) % arrayLength;
            }
            return total;
        }
    }
}