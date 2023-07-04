using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_ApplicationException
{
    internal class BankAccount
    {
        // Task 1: 1. Create a custom exception class called InsufficientFundsException.
        // Write a program that simulates a bank account. Implement a withdraw() method
        // that throws the InsufficientFundsException if the account balance is less than
        // the withdrawal amount. Catch the exception and display an appropriate error message.
        private decimal balance;

        public BankAccount (decimal balance)
        {
            this.balance = balance;
        }
        public decimal Balance
        {
            get { return balance; }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                throw new InsufficientExecutionStackException("your fund is insufficient to process this operation \r\nBank Muscat");
            }
            balance -= amount;
        }
    }
}
