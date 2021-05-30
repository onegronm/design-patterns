using System;

namespace FacadeMortgageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Facade
            Mortgage mortage = new Mortgage();

            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortage.IsEligible(customer, 12500);

            Console.WriteLine(customer.Name + " has been " + (eligible ? "approved" : "rejected"));
        }
    }
}
