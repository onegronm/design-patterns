using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeMortgageDemo
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>
    public class Mortgage
    {
        private Bank _bank = new Bank();
        private Loan _loan = new Loan();
        private Credit _credit = new Credit();

        public bool IsEligible(Customer cust, int amount)
        {
            bool eligible = true; ;

            if (!_bank.HasSuficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
