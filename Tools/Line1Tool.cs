using System;
using Tools.Decorators;
using Tools.Interfaces;

namespace Tools
{
    public class Line1Tool : IPaintTool
    {
        private int x0, y0, x1, y1;

        private Line1Tool(){}

        public static IPaintTool Build()
        {
            return new UpDownPaintToolDecorator(new Line1Tool());
        }

        public void OnMouseClick(int x, int y)
        {
            x0 = x;
            y0 = y;
            x1 = x;
            y1 = y;
        }

        public void OnMouseClicked(int x, int y)
        {
            x1 = x;
            y1 = y;
        }

        public void OnMouseMoved(int x, int y)
        {
            x1 = x;
            y1 = y;
        }

        public void Draw(IPixelSet pixelSet, IDrawingArea drawingArea)
        {
            int a = y1 - y0;
            int b = x0 - x1;
            int c = x1 * y0 - x0 * y1;

            if (Math.Abs(x0 - x1) > Math.Abs(y0-y1))
            {
                int dx = x0 > x1 ? -1 : 1;
                for (int i = x0; i != x1; i += dx)
                {
                    int x = i;
                    int y = (b == 0) ? y0 : (-c - a * i) / b ;
                    pixelSet.DrawPixel(x, y);
                }
            }
            else
            {
                int dy = y0 > y1 ? -1 : 1;
                for (int i = y0; i != y1; i += dy)
                {
                    int x = (a == 0) ? x0 : (-c - b * i) / a;
                    int y = i;
                    pixelSet.DrawPixel(x, y);
                }
            }
        }
    }
}
