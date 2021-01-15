using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Transactions
{
    public class Withdraw : ITransaction
    {
        Account account;
        decimal amount;

        public Withdraw(Account account, decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Must withdraw positive amount.");
            }
            this.account = account;
            this.amount = amount;
        }

        public void Commit()
        {            
            account.Balance = account.Balance - amount;
            Console.WriteLine("Withdrew {0}", amount);
        }
    }
}
