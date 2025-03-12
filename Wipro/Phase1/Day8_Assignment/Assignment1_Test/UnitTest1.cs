using BasicCalculator;
using System;
using NUnit.Framework;

namespace Assignment1_Test
{
    /// <summary>
    /// Test cases used to check for possible problem occurences
    /// </summary>
    public class Tests
    {
        //Test case to check for addition of proper given numbers
        [Test]
        public void Test_Add_ForCorrectInputValues()
        {
            double result = Calculate.Add(5.0, 8.0);
            double expected = 13.0;
            Assert.That(result == expected);
        }

        //Test case to check for addition of given number and zero
        [Test]
        public void Test_Add_ForInputValuesWithZero()
        {
            double result = Calculate.Add(0.0, 8.0);
            double expected = 8.0;
            Assert.That(result == expected);
        }

        //Test case to check for subtraction of proper given numbers
        [Test]
        public void Test_Subtract_ForCorrectInputValues()
        {
            double result = Calculate.Subtract(5.0, 8.0);
            double expected = -3.0;
            Assert.That(result == expected);
        }

        //Test case to check for subtraction of given number and zero
        [Test]
        public void Test_Subtract_ForInputValuesWithZero()
        {
            double result = Calculate.Subtract(5.0, 0.0);
            double expected = 5.0;
            Assert.That(result == expected);
        }

        //Test case to check for multiplication of proper given numbers
        [Test]
        public void Test_Multiply_ForCorrectInputValues()
        {
            double result = Calculate.Multiply(5.0, 8.0);
            double expected = 40.0;
            Assert.That(result == expected);
        }

        //Test case to check for multiplication of given number and zero
        [Test]
        public void Test_Multiply_ForCorrectInputValuesWithZero()
        {
            double result = Calculate.Multiply(5.0, 0.0);
            double expected = 0.0;
            Assert.That(result == expected);
        }

        //Test case to check for divison of proper given numbers
        [Test]
        public void Test_Divide_ForCorrectInputValues()
        {
            double result = Calculate.Divide(15.0, 3.0);
            double expected = 5.0;
            Assert.That(result == expected);
        }

        //Test case to check for divison by zero error
        [Test]
         public void Test_Divide_ForThrowingDivideByZeroException()
        {
          
            Assert.That(() => Calculate.Divide(5.0, 0.0),
            Throws.TypeOf<DivideByZeroException>().With.Message.Contains("Cannot divide by zero."));
        }
       
    }
}
