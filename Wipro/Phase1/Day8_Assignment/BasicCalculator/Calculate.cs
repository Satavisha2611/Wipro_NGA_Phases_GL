using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{

    //A basic calculator class containing methods for each operation
    public class Calculate
    {
        //Addition of two double values
        public static double Add(double a, double b) => a + b;

        //Subtraction of two double values
        public static double Subtract(double a, double b) => a - b;

        //Multiplication of two double values
        public static double Multiply(double a, double b) => a * b;

        //Division of two double values
        public static double Divide(double a, double b) => (b != 0.0)? 
            (a / b) : throw new DivideByZeroException("Cannot divide by zero."); 

    }
}
