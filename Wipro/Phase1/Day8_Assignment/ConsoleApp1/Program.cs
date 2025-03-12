using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BasicCalculator;

namespace Assignment1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompts user to enter the first double value
            Console.WriteLine("Enter first number:");
            double a = Convert.ToDouble(Console.ReadLine());

            //Prompts user to enter the second double value
            Console.WriteLine("Enter second number:");
            double b = Convert.ToDouble(Console.ReadLine());

            //Printing the sum of the user-given numbers
            Console.WriteLine($"Sum: {Calculate.Add(a,b)}");

            //Printing the difference of the user-given numbers
            Console.WriteLine($"Difference: {Calculate.Subtract(a, b)}");

            //Printing the product of the user-given numbers
            Console.WriteLine($"Product: {Calculate.Multiply(a, b)}");

            //try-catch block to catch DivideByZeroException
            try
            {
                Console.WriteLine($"Quotient: {Calculate.Divide(a, b)}"); //Prints the quotient
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division by zero is not possible.." + ex.Message);
                //Handles the DivideByZeroException
            }

        }

    }
}
