using BankApp.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Name = "First Nautical Bank";

            Account individual = new IndividualAccount("john", 1000);
            bank.AddAccount(individual);

            individual.StartTransaction(new Deposit(individual, 1000));
            individual.CommitTransaction();

            individual.StartTransaction(new Withdraw(individual, 500));
            individual.CommitTransaction();

            Account moneyMarket = new MoneyMarketAccount("jane", 500);
            bank.AddAccount(moneyMarket);

            individual.StartTransaction(new Deposit(moneyMarket, 1000));
            individual.CommitTransaction();
            individual.StartTransaction(new Withdraw(moneyMarket, 500));
            individual.CommitTransaction();

            individual.StartTransaction(new Transfer(individual, moneyMarket, 500));
            individual.CommitTransaction();

            Account savings = new Savings("mark", 10000);
            bank.AddAccount(savings);
            individual.StartTransaction(new Deposit(savings, 1000));
            individual.CommitTransaction();
            individual.StartTransaction(new Withdraw(savings, 500));
            individual.CommitTransaction();

            Console.ReadLine();
        }
    }
}
