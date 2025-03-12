using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;

namespace SolidPrinciples
{


    public abstract class BankAccount
    {

        protected double balance;

        public virtual void Deposit(double amount)
        {

            balance += amount;
        }

        public abstract void withdraw(double amount);
        //{
        //    //if (balance >= amount)
        //    //{
        //    //    balance -= amount;
        //    //}
        //    //else
        //    //{
        //    //    throw new InvalidOperationException("Insufficient Balance");

        //    //}

        //}

        public double GetBalance()
        {
            return balance;
        }
    }

    public class SavingsAccount : BankAccount
    {
        public override void withdraw(double amount)

        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient Balance");

            }

        }
    }

    public class FixedDeposit : BankAccount
    {
        public override void withdraw(double amount)
        {
           // base.withdraw(amount);
            throw new InvalidOperationException("Withdraw is not allowed.");

        }
    }
}


