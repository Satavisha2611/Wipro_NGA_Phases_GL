using System;

namespace Day1
{
    //Day1 activity to find the area of a rectangle by taking user input
    public class AreaOfRectangle
    {
        public static void Area()
        {
        Console.WriteLine("Enter the length of the rectangle:");//user inputs the length
        double length=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the breadth of the rectangle:");//user inputs the breadth
         double breadth=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Area of a rectangle : "+ (length*breadth)); //printing the area on the console
        }
    }
}