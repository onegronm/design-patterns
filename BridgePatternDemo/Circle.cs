using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternDemo
{
    /*
     * Concrete class implementing the shape interface
     */
    public class Circle : Shape
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius, DrawAPI api)
            : base(api)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void draw()
        {
            drawAPI.drawCircle(radius, x, y);
        }
    }
}
