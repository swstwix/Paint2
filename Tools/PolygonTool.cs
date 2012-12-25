using System;
using System.Collections.Generic;
using System.Linq;
using Tools.Interfaces;

namespace Tools
{
    public class PolygonTool : IPaintTool
    {
        private readonly IList<Line2Tool> lines = new List<Line2Tool>();
        private Line2Tool currentLine;
        private bool cuttingMode;
        private bool end;
        private bool first = true;
        private int xBegin, yBegin;

        public void OnMouseClick(int x, int y)
        {
            if (end)
                return;
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
            currentLine = (Line2Tool)Line2Tool.Build();
            currentLine.OnMouseClick(x, y);
        }

        public void OnMouseClicked(int x, int y)
        {
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

        public void Draw(IPixelSet pixelSet, IDrawingArea drawingArea)
        {
            if (cuttingMode)
            {
                foreach (var line in lines)
                    line.Draw(pixelSet, drawingArea);
                return;
            }
            foreach (var line in lines)
                line.Draw(pixelSet, drawingArea);
            if (currentLine != null)
                currentLine.Draw(pixelSet, drawingArea);
        }

        public void Move(int x, int y)
        {
            foreach (var paintTool in lines)
                paintTool.Move(x, y);
        }

        public void Rotate(int x, int y)
        {
            foreach (var paintTool in lines)
                paintTool.Rotate(x, y);
        }

        public void Cutting(int minx, int maxx, int miny, int maxy)
        {
            cuttingMode = true;
        }

        private bool ToBeEnd(int x, int y)
        {
            return Math.Abs(x - xBegin) + Math.Abs(y - yBegin) < 30;
        }
    }
}