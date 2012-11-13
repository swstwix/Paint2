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
        private readonly int zoom;

        public ProxyGraphics(Graphics graphics, int zoom)
        {
            this.graphics = graphics;
            this.zoom = zoom;
        }

        public void DrawPixel(int x, int y)
        {
            graphics.FillRectangle(Brushes.Black, zoom * x, zoom * y, zoom, zoom);
        }

        public void DrawPreviewPixel(int x, int y)
        {
            graphics.FillRectangle(Brushes.Red, zoom * x, zoom * y, zoom, zoom);
        }
    }
}
