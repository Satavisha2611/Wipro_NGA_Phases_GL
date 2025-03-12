using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
     class MoreExamples
    {
        public static void Main(string[] args)
        {
            /*
             int CalcAddition(int a, int b)
            {
                return a + b;
            }

            int CalcSubtraction(int a, int b)
            {
                return a - b;
            }

            Console.WriteLine();
            */


            string GetyourLuck(int day) => day switch
            {
                1 => "Good Luck",
                2 => "Bad Luck",
                _ => "Can't tell",
            };
        } 
    }
}
