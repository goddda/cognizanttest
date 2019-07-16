using System;
using Mathh;

namespace TestingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var math = new MathManager();
            int n1, n2;
            Console.WriteLine("Enter two numbersss:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            var n3 = math.Add(n1, n2);
            var n4 = math.Subtract(n1, n2);
            Console.WriteLine($"Sum: {n1}+{n2}={n3}");
            Console.WriteLine($"Subtraction: {n1}-{n2}={n4}");

            /* Static */
            // var myconst = Math.myconstant;
        }
    }
}
