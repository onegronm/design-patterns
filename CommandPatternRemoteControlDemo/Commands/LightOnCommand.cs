using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternRemoteControlDemo
{
    /// <summary>
    /// This is a command
    /// </summary>
    public class LightOnCommand : ICommand
    {
        Light light; // receiver of the request

        public LightOnCommand(Light light) // passing the light this command is going to control
        {
            this.light = light;
        }

        public void execute()
        {
            light.on();
        }
    }
}
