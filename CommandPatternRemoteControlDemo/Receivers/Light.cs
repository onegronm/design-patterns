using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternRemoteControlDemo
{
    public class Light
    {
        public void on() {
            Console.WriteLine("Turned on light.");
        }

        public void off()
        {
            Console.WriteLine("Turned off light.");
        }
    }
}
