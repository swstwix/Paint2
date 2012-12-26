using System.Collections.Generic;
using System.Linq;
using Tools.Arguments;
using Tools.Helpers;
using Tools.Interfaces;

namespace Tools
{
    public class SplineLine : IPaintTool
    {
        private readonly IList<IDragAndDropPoint> dragAndDropPoints = new List<IDragAndDropPoint>();
        private IDrawingArea drawingArea;

        public void OnMouseClick(int x, int y)
        {
            if (dragAndDropPoints.Count < 4)
                dragAndDropPoints.Add(drawingArea.DragDropPoint(x, y));
        }

        public void OnMouseClicked(int x, int y)
        {
        }

        public void OnMouseMoved(int x, int y)
        {
        }

        public void Draw(IPixelSet pixelSet, IDrawingArea drawingArea)
        {
            this.drawingArea = drawingArea;
            if (dragAndDropPoints.Count != 4)
                return;
            SplineHelper.Splaynn spline = new SplineHelper.Splaynn();
            spline.splayn(dragAndDropPoints.Select(x => (double)x.X).ToArray(), dragAndDropPoints.Select(x => (double)x.Y).ToArray());
            for (double i = dragAndDropPoints.Min(x => x.X); i <= dragAndDropPoints.Max(x => x.X); i += 0.01 )
            {
                pixelSet.DrawPixel((int)i, (int)spline.func(i));
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