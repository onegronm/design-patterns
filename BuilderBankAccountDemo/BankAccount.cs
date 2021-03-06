using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderBankAccountDemo
{
    public class BankAccount
    {
        private long accountNumber;
        private string owner;
        private decimal balance;

        // new requirements
        private string branch;
        private double interestRate;

        public BankAccount(long accountNumber, string owner, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.owner = owner;
            this.balance = balance;
        }

        // new constructor
        /*
         * If we have multiple consecutive arguments of the same type, it's easy to accidentally swap them around. 
         * Since the compiler doesn't pick it up as an error, it can manifest as an issue somewhere down the line at 
         * runtime – and that can turn into a tricky debugging exercise. In addition, adding more constructor parameters 
         * results in code that becomes harder to read . If we had 10 different parameters, it would become very difficult
         * to identify what's what in the constructor at a single glance. To make it worse, some of those values might be
         * optional, which means that we'll need to create a bunch of overloaded constructors to deal with all possible 
         * combinations, or we'll have to pass nulls to our constructor (ugly!)
         * there are two specific problems that we need to solve:
            - Too many constructor arguments.
            - Incorrect object state.

            Builder pattern allows us to write readable, understandable code to set up complex objects. It is often implemented with a fluent interface
         */
        public BankAccount(long accountNumber, String owner, String branch, decimal balance, double interestRate)
        {
            this.accountNumber = accountNumber;
            this.owner = owner;
            this.branch = branch;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        // getters and setters omitted for brevity
    }
}
