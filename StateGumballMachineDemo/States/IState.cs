using System;
using System.Collections.Generic;
using System.Text;

namespace StateGumballMachineDemo.States
{
    /// <summary>
    /// Here's the interface for all states. The methods map DIRECTLY to actions that could happen to the Gumball Machine
    /// </summary>
    public interface IState
    {
        void insertQuarter();
        void ejectQuarter();
        void turnCrank();
        void dispense();
    }
}
