using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.Helpers
{
    public static class ArrayHelper
    {
        public static void PrintArray(int[] arr)
        {
            string str = "";
            foreach (var item in arr)
                str += item.ToString() + ",";
            str = str.Remove(str.Length - 1);
            Console.WriteLine(str);
        }

        public static void PrintArray(string[] arr)
        {
            string str = "";
            foreach (var item in arr)
                str += item + ",";
            str = str.Remove(str.Length - 1);
            Console.WriteLine(str);
        }
    }
}