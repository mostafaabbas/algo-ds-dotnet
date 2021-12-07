using System;

namespace algo_ds_dotnet.Algorithms.Lesson6_Recursion
{
    public static class NumPower_Excercise
    {
        public static void Run()
        {
            Console.WriteLine($"This whould return 1: ==> {NumPower(2, 0)}");
            Console.WriteLine($"This whould return 4: ==> {NumPower(2, -2)}");
            Console.WriteLine($"This whould return 16: ==> {NumPower(2, 4)}");
        }


        private static int NumPower(int num, int expon)
        {
            //base case
            if (expon == 0)
                return 1;

            return num * NumPower(num, (expon > 0 ? --expon : ++expon)); //different input
        }
    }
}