using System;
using Tools.Arguments;
using Tools.Decorators;
using Tools.Interfaces;

namespace Tools
{
    public class CuttingTool : IPaintTool
    {
        private int x0;
        private int x1;
        private int y0;
        private int y1;
        private CuttingArguments cutPoint;

        private CuttingTool()
        {
        }

        public void OnMouseClick(int x, int y)
        {
            x0 = x;
            y0 = y;
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
            var cut = new CuttingArguments
                {
                    MinX = Math.Min(x0, x1),
                    MinY = Math.Min(y0, y1),
                    MaxX = Math.Max(x0, x1),
                    MaxY = Math.Max(y0, y1),
                };

            IPaintTool line1 = Line2Tool.Build();
            line1.OnMouseClick(cut.MinX, cut.MinY);
            line1.OnMouseClicked(cut.MinX, cut.MaxY);
            line1.Draw(pixelSet, drawingArea);
            IPaintTool line2 = Line2Tool.Build();
            line2.OnMouseClick(cut.MinX, cut.MaxY);
            line2.OnMouseClicked(cut.MaxX, cut.MaxY);
            line2.Draw(pixelSet, drawingArea);
            IPaintTool line3 = Line2Tool.Build();
            line3.OnMouseClick(cut.MaxX, cut.MaxY);
            line3.OnMouseClicked(cut.MaxX, cut.MinY);
            line3.Draw(pixelSet, drawingArea);
            IPaintTool line4 = Line2Tool.Build();
            line4.OnMouseClick(cut.MaxX, cut.MinY);
            line4.OnMouseClicked(cut.MinX, cut.MinY);
            line4.Draw(pixelSet, drawingArea);

            foreach (IPaintTool paintTool in drawingArea)
            {
                paintTool.Cutting(cut);
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
            this.cutPoint = cut;
        }

        public static IPaintTool Build()
        {
            return new UpDownPaintToolDecorator(new CuttingTool());
        }
    }
}