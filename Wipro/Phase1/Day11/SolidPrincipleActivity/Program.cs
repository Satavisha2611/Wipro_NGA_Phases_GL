// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleActivity
{
    public class Program
    {
        static void Main(string[] args)
        {
            int ch = Convert.ToInt32(Console.ReadLine());
            
            switch (ch)
            {
                case 1: IPayment ccd = new CreditCard(); // creating object of credit card to be passed for the dependency
                    Payment executePayment = new Payment(ccd);
                    executePayment.ExecutePayment();
                    break;

                case 2:
                    IPayment ptm = new PayTm(); // creating object of paytm to be passed for the dependency
                    Payment executePayment1 = new Payment(ptm);
                    executePayment1.ExecutePayment();
                    break;
            }
        }
    }
}
