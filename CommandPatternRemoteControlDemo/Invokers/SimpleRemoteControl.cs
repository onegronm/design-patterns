using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternRemoteControlDemo
{
    /// <summary>
    /// The Invoker class
    /// </summary>
    public class SimpleRemoteControl
    {
        // one slot to hold our command, which will control one device
        ICommand slot;

        public SimpleRemoteControl()
        {

        }

        /// <summary>
        /// Method for setting the command the slot is going to control
        /// Could be called multiple times if the client of this code wanted to change the behavior of the remote button
        /// </summary>
        /// <param name="command"></param>
        public void setCommand(ICommand command)
        {
            slot = command;
        }

        /// <summary>
        /// Take the current command bound do the slot and call execute() method
        /// </summary>
        public void buttonWasPressed()
        {
            slot.execute();
        }
    }
}
