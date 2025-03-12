using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleActivity
{
    public interface IPayment
    {
        void ProcessPayment();
    }


    public class CreditCard : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("This is a credit card payment.");
        }
    }

    public class PayTm : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("This is an online Paytm payment.");
        }
    }


    public class Payment
    {
        private readonly IPayment payment;
        public Payment(IPayment pm)
        {
            payment = pm;
        }
        public void ExecutePayment()
        {
            payment.ProcessPayment();
        }

    }
}
