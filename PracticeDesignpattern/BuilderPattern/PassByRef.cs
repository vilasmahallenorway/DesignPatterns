using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class PassByRefference
    {
        // In pass by Ref : Pass by ref actual value gets changed
        static void Main3(string[] args)
        {
            int x = 5, y = 6;

            PassByRef(ref x, ref y);

            Console.WriteLine($"value of number X => {x} and Y => {y} ");
            Console.ReadLine();
        }

        private static void PassByRef(ref int x, ref int y)
        {
            x = 100;
            y = 200;
        }
    }
}
