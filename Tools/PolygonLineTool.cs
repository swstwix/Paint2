using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Arguments;
using Tools.Decorators;
using Tools.Helpers;
using Tools.Interfaces;

namespace Tools
{
    public class PolygonLineTool : IPaintTool
    {
        private int x0, y0, x1, y1;
        private bool cutted = false;
        private CuttingArguments cutArgs;

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

            if (cutted && Otsechenie.Vne(cutArgs, x0, y0, x1, y1))
                return;
            var deltaX = Math.Abs(x1 - x0);
            var deltaY = Math.Abs(y1 - y0);
            var signX = x0 < x1 ? 1 : -1;
            var signY = y0 < y1 ? 1 : -1;
            //
            int error = deltaX - deltaY;
            //
            pixelSet.DrawPixel(x1, y1);

            int x2 = x0;
            int y2 = y0;

            while (x2 != x1 || y2 != y1)
            {
                if (!cutted || !Otsechenie.Vne(cutArgs, x2, y2))
                    pixelSet.DrawPixel(x2, y2);

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

        public void Move(int x, int y)
        {
            x0 += x;
            y0 += y;
            x1 += x;
            y1 += y;
        }

        public void Rotate(int x, int y)
        {
            var newx0 = RotateHelper.RotateX(x0, y0, x, y);
            var newy0 = RotateHelper.RotateY(x0, y0, x, y);
            var newx1 = RotateHelper.RotateX(x1, y1, x, y);
            var newy1 = RotateHelper.RotateY(x1, y1, x, y);

            x0 = newx0;
            x1 = newx1;
            y0 = newy0;
            y1 = newy1;
        }

        public void Cutting(CuttingArguments cut)
        {
            cutted = true;
            this.cutArgs = cut;
        }
    }
}
