using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Interfaces;

namespace Tools
{
    public class LineFloodFill : IPaintTool
    {
        private int x0, y0;

        public void OnMouseClick(int x, int y)
        {
            x0 = x;
            y0 = y;
        }

        public void OnMouseClicked(int x, int y)
        {
        }

        public void OnMouseMoved(int x, int y)
        {
        }

        public void Draw(IPixelSet pixelSet, IDrawingArea drawingArea)
        {
            
        }
    }
}
