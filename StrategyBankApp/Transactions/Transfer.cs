using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Transactions
{
    public class Transfer : ITransaction
    {
        Account account1;
        Account account2;
        decimal amount;

        public Transfer(Account account1, Account account2, decimal amount)
        {
            this.account1 = account1;
            this.account2 = account2;
            this.amount = amount;
        }

        public void Commit()
        {
            // withdraw from account1
            account1.Balance -= amount;
            // deposit in account2
            account2.Balance += amount;

            Console.WriteLine("Transferred {0} from {1} to {2}", amount, account1.Owner.Name, account2.Owner.Name);
        }
    }
}
