using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_ds_dotnet.Algorithms.Lesson6_Recursion
{
    public static class Fibonacci_Excercise
    {
        public static void Run()
        {
            Console.WriteLine($"This should return 3: => {Fibonacci(4)}");
            Console.WriteLine($"This should return 55: => {Fibonacci(10)}");
            Console.WriteLine($"This should return 317811: => {Fibonacci(28)}");
            Console.WriteLine($"This should return 9227465: => {Fibonacci(35)}");
        }


        private static int Fibonacci(int n)
        {
            if (n <= 2) return 1; //base case
            return Fibonacci(n - 1) + Fibonacci(n - 2); //different input
        }
    }
}
