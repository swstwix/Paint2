using System;
using Tools.Interfaces;

namespace Tools
{
    public class Line1Tool : IPaintTool
    {
        private int x0, y0, x1, y1;
        private bool afterMouseClick = false;
        private bool afterMouseClicked = false;

        public void OnMouseClick(int x, int y)
        {
            if (afterMouseClicked)
                return;
            x0 = x;
            y0 = y;
            afterMouseClick = true;
        }

        public void OnMouseClicked(int x, int y)
        {
            if (afterMouseClicked)
                return;
            x1 = x;
            y1 = y;
            afterMouseClicked = true;
        }

        public void OnMouseMoved(int x, int y)
        {
            if (afterMouseClicked)
                return;
            x1 = x;
            y1 = y;
        }

        public void Draw(IGraphics graphics)
        {
            if (!afterMouseClick)
                return;

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
                    if (afterMouseClicked)
                        graphics.DrawPixel(x, y);
                    else
                        graphics.DrawPreviewPixel(x, y);
                }
            }
            else
            {
                int dy = y0 > y1 ? -1 : 1;
                for (int i = y0; i != y1; i += dy)
                {
                    int x = (a == 0) ? x0 : (-c - b * i) / a;
                    int y = i;
                    if (afterMouseClicked)
                        graphics.DrawPixel(x, y);
                    else
                        graphics.DrawPreviewPixel(x, y);
                }
            }
        }
    }
}
