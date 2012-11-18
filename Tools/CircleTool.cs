using System;
using Tools.Decorators;
using Tools.Interfaces;

namespace Tools
{
    public class CircleTool : IPaintTool
    {
        private int x0, y0;
        private int r;

        private CircleTool(){}

        public static IPaintTool Build()
        {
            return new UpDownPaintToolDecorator(new CircleTool());
        }

        public void OnMouseClick(int x, int y)
        {
            x0 = x;
            y0 = y;
        }

        public void OnMouseClicked(int x, int y)
        {
            r = (int) Math.Sqrt(Math.Abs(x - x0)*Math.Abs(x - x0) + Math.Abs(y - y0)*Math.Abs(y - y0));
        }

        public void OnMouseMoved(int x, int y)
        {
            r = (int)Math.Sqrt(Math.Abs(x - x0) * Math.Abs(x - x0) + Math.Abs(y - y0) * Math.Abs(y - y0));
        }

        public void Draw(IPixelSet pixelSet, IDrawingArea drawingArea)
        {
            int delta = 1 - 1 * r;
            int x = 0;
            int y = r;
            while (y >= 0)
            {
                PutPixel(pixelSet, x0 + x, y0 + y);
                PutPixel(pixelSet, x0 + x, y0 - y);
                PutPixel(pixelSet, x0 - x, y0 + y);
                PutPixel(pixelSet, x0 - x, y0 - y);
                int error = 2 * (delta + y) - 1;
                if (delta < 0 && error <= 0)
                {
                    ++x;
                    delta += 2 * x + 1;
                    continue;
                }
                error = 2 * (delta - x) - 1;
                if (delta > 0 && error > 0)
                {
                    --y;
                    delta += 1 - 2 * y;
                    continue;
                }
                ++x;
                delta += 2 * (x - y);
                --y;
            }
        }

        private void PutPixel(IPixelSet g, int x, int y)
        {
            g.DrawPixel(x, y);
        }
    }
}
