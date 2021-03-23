using System;
using System.Collections.Generic;
using System.Text;

namespace StateGumballMachineDemo.States
{
    public class SoldState : IState
    {
        GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            // we're in the sold state, which means the customer paid.
            // So, we first need to ask the machine to release a gumball.
            gumballMachine.releaseBall();
            if(gumballMachine.getCount() > 0)
            {
                gumballMachine.setState(gumballMachine.getNoQuarterState());
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void insertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void turnCrank()
        {
            throw new NotImplementedException();
        }
    }
}
