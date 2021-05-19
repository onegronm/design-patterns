using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterTurkeyDemo
{
    public class MallardDuck : Duck
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
        
        public void fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
