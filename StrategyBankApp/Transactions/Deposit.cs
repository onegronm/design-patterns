using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Transactions
{
    public class Deposit : ITransaction
    {
        Account account;
        decimal amount;

        public Deposit(Account account, decimal amount)
        {
            this.account = account;
            this.amount = amount;
        }

        public void Commit()
        {
            if (amount <= 0)
                throw new ArgumentException("You must enter a positive amount to deposit.");
            else
            {
                account.Balance = account.Balance + amount;
                Console.WriteLine("Deposited {0}", amount);
            }
        }
    }
}
