namespace FacadeMortgageDemo
{
    public class Customer
    {
        public string Name { get; internal set; }

        public Customer(string name)
        {
            Name = name;
        }
    }
}