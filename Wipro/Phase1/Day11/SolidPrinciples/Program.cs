using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount account = new SavingsAccount();
            FixedDeposit fd = new FixedDeposit();
            try
            {
                account.Deposit(200.00);
                account.withdraw(30.00);
                Console.WriteLine(account.GetBalance());

                fd.withdraw(40.00);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
    }
}
