using System;

namespace algo_ds_dotnet.Algorithms.Lesson1_BigONot
{
    public static class NestedLoop
    {
        public static void NestedListTest()
        {

        }


        //Big O Notation => O(n * n)
        public static void NestedList_1(int n)
        {
            Console.WriteLine("Big O Notation => O(n * n)");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //Console.WriteLine($"{i}, {j}");
                }
            }
        }
    }
}