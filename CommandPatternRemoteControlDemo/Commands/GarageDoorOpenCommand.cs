using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternRemoteControlDemo.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor garageDoor; // receiver

        public GarageDoorOpenCommand(GarageDoor door)
        {
            this.garageDoor = door;
        }

        public void execute()
        {
            garageDoor.up();
        }
    }
}
