using System;

namespace BuilderBankAccountDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new Builder(1234L)
                .withOwner("Marge")
                .atBranch("Springfield")
                .openingBalance(100)
                .atRate(2.5)
                .build();

            BankAccount anotherAccount = new Builder(1234L)
                .withOwner("Homer")
                .atBranch("Springfield")
                .openingBalance(100)
                .atRate(2.5)
                .build();
        }
    }
}
