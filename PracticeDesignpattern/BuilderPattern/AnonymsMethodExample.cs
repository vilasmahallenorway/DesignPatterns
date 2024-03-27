using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class AnonymsMethodExample
    {
        // Anonymous methods provide a way to define inline delegate implementations
        // without the need to explicitly declare a separate method, making the code more concise and readable,
        // especially for short and simple operations.

        // delegate int SumDelegate(int num1, int num2);
        static void Main1(string[] args)
        {
            // SumDelegate del = Sum;

            //SumDelegate del = delegate (int num1, int num2) { return num1 + num2; };

            // here instead of delegate we can use var, But for Annonyms mehthod we need delegate
            var del = delegate (int num1, int num2) { return num1 + num2; };

            Console.WriteLine($"Sum of number is {del(2, 3)}");
            Console.ReadLine();
        }
        // in annonyms method we dont need to expose extra method block
        private static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
