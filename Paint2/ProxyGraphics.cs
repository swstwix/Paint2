using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Interfaces;

namespace Paint2
{
    public class ProxyGraphics : IGraphics
    {
        private readonly Graphics graphics;

        public ProxyGraphics(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public void DrawPixel(int x, int y)
        {
            graphics.FillRectangle(Brushes.Black, x, y, 1, 1);
        }
    }
}
