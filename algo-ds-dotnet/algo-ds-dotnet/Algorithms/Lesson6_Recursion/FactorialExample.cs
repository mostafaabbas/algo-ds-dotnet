using System;

namespace algo_ds_dotnet.Algorithms.Lesson6_Recursion
{
    public static class FactorialExample
    {
        public static void Run()
        {
            Console.WriteLine($"Factorial(3) should be 6: ==> {Factorial_No_Recursive(3)}");
            Console.WriteLine($"Factorial(4) should be 24: ==> {Factorial_No_Recursive(4)}");

            Console.WriteLine($"Factorial(3) should be 6: ==> {Factorial_Recursive(3)}");
            Console.WriteLine($"Factorial(4) should be 24: ==> {Factorial_Recursive(4)}");
        }

        //factorial: num * num -1 * num-2 * ......
        //factorial(4): 4!: 4 * 3 * 2 * 1
        private static int Factorial_No_Recursive(int num)
        {
            int total = 1;
            for (int i = num; i > 0; i--)
            {
                total *= i;
            }
            return total;
        }


        private static int Factorial_Recursive(int num)
        {
            //base case
            if (num < 1) return 1;

            return num * Factorial_Recursive(num - 1); //different input
        }
    }
}