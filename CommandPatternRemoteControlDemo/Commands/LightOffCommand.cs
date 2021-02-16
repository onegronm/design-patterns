using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternRemoteControlDemo.Commands
{
    public class LightOffCommand : ICommand
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.off();
        }
    }
}
