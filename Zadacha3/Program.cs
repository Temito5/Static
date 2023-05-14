using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers you want to enter? : ");
            int n = int.Parse(Console.ReadLine());

            SquareRootPrecalculator calculator = new SquareRootPrecalculator();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                double squareRoot = calculator.FindSquareRoot(number);
                Console.WriteLine(squareRoot);
            }
        }
    }
}
