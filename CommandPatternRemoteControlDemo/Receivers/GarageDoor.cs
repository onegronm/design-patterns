using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternRemoteControlDemo
{
    public class GarageDoor
    {
        public void up()
        {
            Console.WriteLine("Opened garage door.");
        }

        public void down()
        {
            Console.WriteLine("Closed garage door.");
        }

        public void stop()
        {
            Console.WriteLine("Stopped garage door.");
        }

        public void lightOn()
        {
            Console.WriteLine("Turned on the garage light.");
        }

        public void lightOff()
        {
            Console.WriteLine("Turned off the garage light.");
        }
    }
}
