using StateGumballMachineDemo.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateGumballMachineDemo
{
    public class GumballMachine
    {
        IState soldOutState;
        IState noQuarterState;
        IState hasQuarterState;
        IState soldState;

        IState state;
        int count = 0;

        public GumballMachine(int count)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);

            this.count = count;
            if(this.count > 0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }

        public void insertQuarter()
        {
            state.insertQuarter();
        }

        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }

        public void setState(IState state)
        {
            this.state = state;
        }

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if(this.count != 0)
            {
                this.count = count - 1;
            }
        }

        public IState getNoQuarterState()
        {
            return noQuarterState;
        }

        public IState getHasQuarterState()
        {
            return hasQuarterState;
        }

        public IState getSoldState()
        {
            return soldState;
        }

        public IState getSoldOutState()
        {
            return soldOutState;
        }

        public int getCount()
        {
            return this.count;
        }
    }
}
