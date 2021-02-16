using CommandPatternRemoteControlDemo.Commands;
using System;

namespace CommandPatternRemoteControlDemo
{
    class Program
    {
        /// <summary>
        /// The client or "customer" - responsible for creating the concrete command and setting its receiver
        /// Waitress/remote = invoker - holds a command and at some point asks the command to carry out a request
        /// Cook/vendor class = receiver - knows how to perform the work needed to carry out the request
        /// orderUp()/press button = setCommand()
        /// Order/Device action = command - invoked through its execute() method which asks the receiver to perform an action. Binds action to a receiver
        /// Customer/user = client
        /// takeOrder()/buttonPressed() = execute() - invokes actions on the receiver needed to fulfill the request
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl(); // the INVOKER or "waitress" can be parameterized with different requests
            
            Light light = new Light(); // the RECEIVER of the request or "the cook"
            LightOnCommand lightOn = new LightOnCommand(light); // create a COMMAND and pass the receiver to it or "the order"

            GarageDoor door = new GarageDoor();// the RECEIVER
            GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(door); // the COMMAND

            remote.setCommand(lightOn); // pass the COMMAND to the INVOKER or "takeOrder()
            remote.buttonWasPressed(); // calls execute() or "orderUp()"
            remote.setCommand(garageOpen);
            remote.buttonWasPressed();
        }
    }
}
