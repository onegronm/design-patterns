using System;
using System.Collections.Generic;
using System.Text;

namespace StateGumballMachineDemo.States
{
    public class NoQuarterState : IState
    {
        GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine machine)
        {
            gumballMachine = machine;
        }

        public void dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void insertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.setState(gumballMachine.getHasQuarterState());
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }
    }
}
