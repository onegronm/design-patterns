using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeMortgageDemo
{
    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>
    public class Bank
    {
        public bool HasSuficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}
