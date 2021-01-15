using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Account
    {
        ITransaction transaction;

        public Account(string name, decimal initialDeposit)
        {
            if (initialDeposit <= 0)
            {
                throw new ArgumentException("Must deposit positive amount.");
            }
            this.Owner = new Owner();
            this.Owner.Name = name;
            this.Balance = initialDeposit;
        }

        public Owner Owner { get; set; }
        public decimal Balance { get; set; }

        public void StartTransaction(ITransaction _transaction)
        {
            transaction = _transaction;
        }

        public void CommitTransaction()
        {
            transaction.Commit();
        }
    }
}
