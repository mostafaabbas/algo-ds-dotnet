using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.DataStructures.NewFolder
{
    public class CustomHashTable
    {
        public CustomHashTable(int size = 53)
        {
            KeyMap = new List<List<string>>[size];
        }

        public List<List<string>>[] KeyMap { get; private set; }


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
            var arr = KeyMap[index];
            if (arr == null)
                KeyMap[index] = new List<List<string>>();
            KeyMap[index].Add(new List<string> { key, value });
        }
    }
}