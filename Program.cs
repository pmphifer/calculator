using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Input
            
            Console.Write("Give me a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Give me another whole number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Sum of the numbers
            double result = num1 + num2;
            Console.WriteLine("The sum of your numbers is " + result);
            Console.WriteLine();

            //Difference of the numbers
            result = num1 - num2;
            Console.WriteLine("The difference of your numbers is " + result);
            Console.WriteLine();

            //Product of the numbers
            result = num1 * num2;
            Console.WriteLine($"The product of your numbers is {result}");
            Console.WriteLine();

            //Quotient of the numbers
            result = num1 / num2;
            Console.WriteLine($"The quotient of your numbers is {result}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
