using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderBankAccountDemo
{
    public class Builder
    {
        private long accountNumber; //This is important, so we'll pass it to the constructor.
        private string owner;
        private string branch;
        private decimal balance;
        private double interestRate;

        public Builder(long accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public Builder withOwner(string owner)
        {
            this.owner = owner;
            return this;
        }

        public Builder atBranch(string branch)
        {
            this.branch = branch;
            return this;
        }

        public Builder openingBalance(decimal balance)
        {
            this.balance = balance;
            return this;
        }

        public Builder atRate(double interestRate)
        {
            this.interestRate = interestRate;
            return this;
        }

        public BankAccount build()
        {
            //Here we create the actual bank account object, which is always in a fully initialised state when it's returned.
            BankAccount account = new BankAccount();  //Since the builder is in the BankAccount class, we can invoke its private constructor.
            
            account.accountNumber = this.accountNumber;
            account.owner = this.owner;
            account.branch = this.branch;
            account.balance = this.balance;
            account.interestRate = this.interestRate;

            return account;
        }
    }
}
