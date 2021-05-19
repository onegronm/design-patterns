using System;

namespace AdapterTurkeyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();

            WildTurkey turkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The turkey says...");
            turkey.gobble();
            turkey.fly();

            Console.WriteLine("\nThe duck says...");
            duck.quack();
            duck.fly();

            Console.WriteLine("\nThe TurkeyAdapter says...");
            turkeyAdapter.quack();
            turkeyAdapter.fly();
        }
    }
}
