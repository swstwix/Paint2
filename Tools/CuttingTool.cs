using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Arguments;
using Tools.Decorators;
using Tools.Interfaces;

namespace Tools
{
    public class CuttingTool : IPaintTool
    {
        private int x0, y0;
        private int x1, y1;

        private CuttingTool()
        {
        }

        public static IPaintTool Build()
        {
            return  new UpDownPaintToolDecorator(new CuttingTool());
        }

        public void OnMouseClick(int x, int y)
        {
            this.x0 = x;
            this.y0 = y;
        }

        public void OnMouseClicked(int x, int y)
        {
            this.x1 = x;
            this.y1 = y;
        }

        public void OnMouseMoved(int x, int y)
        {
            this.x1 = x;
            this.y1 = y;
        }

        public void Draw(IPixelSet pixelSet, IDrawingArea drawingArea)
        {
            int minx = Math.Min(x0, x1);
            int miny = Math.Min(y0, y1);
            int maxx = Math.Max(x0, x1);
            int maxy = Math.Max(y0, y1);

            var line1 = Line2Tool.Build();
            line1.OnMouseClick(minx, miny);
            line1.OnMouseClicked(minx, maxy);
            line1.Draw(pixelSet, drawingArea);
            var line2 = Line2Tool.Build();
            line2.OnMouseClick(minx, maxy);
            line2.OnMouseClicked(maxx, maxy);
            line2.Draw(pixelSet, drawingArea);
            var line3 = Line2Tool.Build();
            line3.OnMouseClick(maxx, maxy);
            line3.OnMouseClicked(maxx, miny);
            line3.Draw(pixelSet, drawingArea);
            var line4 = Line2Tool.Build();
            line4.OnMouseClick(maxx, miny);
            line4.OnMouseClicked(minx, miny);
            line4.Draw(pixelSet, drawingArea);

            foreach (var paintTool in drawingArea)
            {
                paintTool.Cutting(minx, maxx, miny, maxy);
            }
        }

        public void Move(int x, int y)
        {
        }

        public void Rotate(int x, int y)
        {
        }

        public void Cutting(CuttingArguments cut)
        {
        }

    }
}
