using BridgePatternDemo.Bridge;
using System;

namespace BridgePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(100, 100, 100, new RedCircle());
            Shape greenCircle = new Circle(100, 100, 100, new GreenCircle());

            redCircle.draw();
            greenCircle.draw();
        }
    }
}
