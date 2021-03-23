using System;
using System.Collections.Generic;
using System.Text;

namespace StateGumballMachineDemo.States
{
    public class SoldOutState : IState
    {
        public SoldOutState(GumballMachine machine)
        {
        }

        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void insertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold oud");
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }
    }
}
