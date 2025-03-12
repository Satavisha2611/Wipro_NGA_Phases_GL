using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(1, "Sat", "Student");
            Console.WriteLine(e[2]);

            e["NAME"] = "Sata";
            e["JOB"] = "Trainee";
            Console.WriteLine("After resetting");
            Console.WriteLine(e[1]+" "+e[2]);
        }
      /*
        public static void DisplayArea(Shape shape)
        {
            switch(shape)
            {
                case Circle c:
                    Console.WriteLine($"Area of a circle: {c.radius * c.radius * Shape.PI}");
                    break;

                case Rectangle r when r.length == r.height:
                    Console.WriteLine($"Area of a circle: {r.length * r.height}");
                    break;

                case Rectangle r:
                    Console.WriteLine($"Area of a circle: {r.length * r.height}");
                    break;

                case null:
                    break;
            }
        }*/
       
        

    }
}
