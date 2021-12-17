using System;
using System.Collections.Generic;
using System.Linq;

namespace algo_ds_dotnet.DataStructures.L6_HashTables
{
    public class CustomHashTable
    {
        public CustomHashTable(int size = 53)
        {
            KeyMap = new Dictionary<string, string>[size];
        }

        public Dictionary<string, string>[] KeyMap { get; private set; }


        private int Hash(string key)
        {
            var total = 0;
            var WEIRD_PRIME = 31;
            for (var i = 0; i < Math.Min(key.Length, 100); i++)
            {
                var c = key[i];
                var value = (int)c - 96;
                total = (total * WEIRD_PRIME + value) % KeyMap.Length;
            }
            return total;
        }

        public void Set(string key, string value) //separate chaining
        {
            var index = Hash(key);
            var dic = KeyMap[index];
            if (dic == null)
                KeyMap[index] = new Dictionary<string, string>();
            KeyMap[index].Add(key, value);
        }

        public string Get(string key)
        {
            var index = Hash(key);
            var dic = KeyMap[index];
            if (dic == null)
                return default;
            return dic[key];
        }


        public List<string> Keys
        {
            get
            {
                var keys = new List<string>();
                foreach (var item in KeyMap)
                {
                    if (item != null)
                        keys.AddRange(item.Keys);
                }
                return keys;
            }
        }
        public List<string> Values
        {
            get
            {
                var values = new List<string>();
                foreach (var item in KeyMap)
                {
                    if (item != null)
                        values.AddRange(item.Values);
                }
                return values.Distinct().ToList();
            }
        }
    }
}