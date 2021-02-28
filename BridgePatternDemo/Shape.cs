using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternDemo
{
    /// <summary>
    /// Abstract class Shape using the DrawAPI interface
    /// </summary>
    public abstract class Shape
    {
        protected DrawAPI drawAPI;

        public Shape(DrawAPI api)
        {
            drawAPI = api;
        }

        public abstract void draw();
    }
}
