using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Bank
    {
        public Bank()
        {
            Accounts = new List<Account>();
        }

        public string Name { get; set; }
        public List<Account> Accounts { get; set; }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }
    }
}
