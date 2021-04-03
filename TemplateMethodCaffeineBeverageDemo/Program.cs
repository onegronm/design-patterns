using System;

namespace TemplateMethodCaffeineBeverageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea teaHook = new Tea();
            Coffee coffeeHook = new Coffee();

            Console.WriteLine("\nMaking tea...");
            teaHook.prepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffeeHook.prepareRecipe();
        }
    }
}
