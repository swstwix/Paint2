using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Arguments;
using Tools.Interfaces;

namespace Tools
{
    public class BezieLine : IPaintTool
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

            for (double t = 0; t <= 1; t += 0.001)
            {
                int x = (int) ((1 - t) * (1 - t) * (1 - t) * dragAndDropPoints[0].X + 3 * t * (1 - t) * (1 - t)*dragAndDropPoints[1].X
                    +3 * t * t * (1 - t) * dragAndDropPoints[2].X + t*t*t*dragAndDropPoints[3].X);
                int y =
                    (int) ((1 - t)*(1 - t)*(1 - t)*dragAndDropPoints[0].Y + 3*t*(1 - t)*(1 - t)*dragAndDropPoints[1].Y
                           + 3*t*t*(1 - t)*dragAndDropPoints[2].Y + t*t*t*dragAndDropPoints[3].Y);
                if (pixelSet.IsNotFilled(x, y))
                    pixelSet.DrawPixel(x, y);
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
