using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Interfaces;

namespace Tools
{
    public class PolygonTool : IPaintTool
    {
        private readonly IList<Line2Tool> lines = new List<Line2Tool>();
        private Line2Tool currentLine;
        private int xBegin, yBegin;
        private int x0, y0;
        private int x1, y1;
        private bool first = true;
        private bool end = false;

        public void OnMouseClick(int x, int y)
        {
            if (end)
                return;
            x0 = x;
            y0 = y;
            if (!lines.Any() && first)
            {
                xBegin = x;
                yBegin = y;
                first = false;
            }
            else
            {
                if (ToBeEnd(x, y))
                {
                    currentLine.OnMouseClicked(xBegin, yBegin);
                    lines.Add(currentLine);
                    currentLine = null;
                    end = true;
                    return;
                }
                currentLine.OnMouseClicked(x, y);
                lines.Add(currentLine);
            }
            currentLine = new Line2Tool();
            currentLine.OnMouseClick(x, y);
        }

        public void OnMouseClicked(int x, int y)
        {
            //throw new NotImplementedException();
        }

        public void OnMouseMoved(int x, int y)
        {
            if (end)
                return;
            if (currentLine == null)
                return;
            if (ToBeEnd(x, y))
                currentLine.OnMouseMoved(xBegin, yBegin);
            else
                currentLine.OnMouseMoved(x, y);
        }

        public void Draw(IPixelSet pixelSet)
        {
            foreach (var line in lines)
                line.Draw(pixelSet);
            if (currentLine != null)
              currentLine.Draw(pixelSet);
        }

        bool ToBeEnd(int x, int y)
        {
            return Math.Abs(x - xBegin) + Math.Abs(y - yBegin) < 30;
        }
    }
}
