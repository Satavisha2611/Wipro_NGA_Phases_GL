using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Android : IMobile
    {
        public void NewMobile()
        {
            Console.WriteLine("Creation of a new android mobile.");
        }
    }

    public class IPhone : IMobile
    {
        public void NewMobile()
        {
            Console.WriteLine("Creation of a new iphone mobile.");
        }
    }
}
