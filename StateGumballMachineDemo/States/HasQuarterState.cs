using System;
using System.Collections.Generic;
using System.Text;

namespace StateGumballMachineDemo.States
{
    public class HasQuarterState : IState
    {
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine machine)
        {
            this.gumballMachine = machine;
        }


        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }

        public void insertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned...");
            gumballMachine.setState(gumballMachine.getSoldState());
        }
    }
}
