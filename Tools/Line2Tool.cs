using System;
using Tools.Interfaces;

namespace Tools
{
    public class Line2Tool : IPaintTool
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
            x1 = x;
            y1 = y;
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

        public void Draw(IPixelSet pixelSet)
        {
            if (!afterMouseClick)
                return;

            var deltaX = Math.Abs(x1 - x0);
            var deltaY = Math.Abs(y1 - y0);
            var signX = x0 < x1 ? 1 : -1;
            var signY = y0 < y1 ? 1 : -1;
            //
            int error = deltaX - deltaY;
            //
            if (afterMouseClicked)
                pixelSet.DrawPixel(x1, y1);
            else
                pixelSet.DrawPreviewPixel(x1, y1);

            int x2 = x0;
            int y2 = y0;

            while (x2 != x1 || y2 != y1)
            {
                if (afterMouseClicked)
                    pixelSet.DrawPixel(x2, y2);
                else
                    pixelSet.DrawPreviewPixel(x2, y2);

                int error2 = error * 2;
                //
                if (error2 > -deltaY)
                {
                    error -= deltaY;
                    x2 += signX;
                }
                if (error2 < deltaX)
                {
                    error += deltaX;
                    y2 += signY;
                }
            }
        }
    }
}
