using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternDemo
{
    /// <summary>
    /// The bridge interface
    /// </summary>
    public interface DrawAPI
    {
        public void drawCircle(int radius, int x, int y);
    }
}
