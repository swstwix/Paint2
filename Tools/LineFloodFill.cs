using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tools.Arguments;
using Tools.Interfaces;

namespace Tools
{
    public class LineFloodFill : IPaintTool
    {
        private int x0, y0;
        private HashSet<KeyValuePair<int, int>> allPoints;
        private HashSet<KeyValuePair<int, int>> drawingPoints;
        private IDrawingArea drawingArea;
        private IPixelSet pixelSet;
        private bool afterClick = false;
        private int minY;
        private int maxY;
        private int curY = -1;

        private LineFloodFill()
        {
            
        }

        public static LineFloodFill Build()
        {
            return new LineFloodFill();
        }

        public void OnMouseClick(int x, int y)
        {
            x0 = x;
            y0 = y;
            afterClick = true;
        }

        public void OnMouseClicked(int x, int y)
        {
        }

        public void OnMouseMoved(int x, int y)
        {
        }

        public void Draw(IPixelSet pixelSet, IDrawingArea drawingArea)
        {
            if (!afterClick)
                return;
            if (allPoints == null)
            {
                this.pixelSet = pixelSet;
                allPoints = new HashSet<KeyValuePair<int, int>>(new Comparer());
                drawingPoints= new HashSet<KeyValuePair<int, int>>(new Comparer());
                this.drawingArea = drawingArea;
                startFill();
                minY = allPoints.Min(x => x.Value);
                maxY = allPoints.Max(x => x.Value);
                ThreadPool.QueueUserWorkItem(fedos);
            }
            lock(drawingPoints)
                foreach (var x in drawingPoints)
                    pixelSet.FillCell(x.Key, x.Value);
        }

        private void fedos(Object o)
        {
            var ymas = allPoints.Select(x => x.Value).Distinct().OrderBy(x => x);
            for (int i = y0 + 1; i <= ymas.Max(); i++)
            {
                lock(drawingPoints)
                    foreach (var p in allPoints.Where(x => x.Value == i))
                    {
                        drawingPoints.Add(p);
                    }
                Thread.CurrentThread.Join(50);
                drawingArea.Redraw();
            }
            for (int i = y0; i >= ymas.Min(); i--)
            {
                lock (drawingPoints)
                    foreach (var p in allPoints.Where(x => x.Value == i))
                    {
                        drawingPoints.Add(p);
                    }
                Thread.CurrentThread.Join(50);
                drawingArea.Redraw();
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

        private void startFill()
        {
            fill(x0, y0);
        }

        private void fill(int x, int y)
        {
            if (!pixelSet.CellIsInArea(x, y))
                return;
            if (!pixelSet.IsNotFilled(x, y))
                return;
            if (allPoints.Contains(new KeyValuePair<int, int>(x, y)))
                return;
            allPoints.Add(new KeyValuePair<int, int>(x,y));
            fill(x + 1, y);
            fill(x - 1, y);
            fill(x, y - 1);
            fill(x, y + 1);
        }

        class Comparer : IEqualityComparer<KeyValuePair<int, int>>
        {
            public bool Equals(KeyValuePair<int, int> x, KeyValuePair<int, int> y)
            {
                return x.Key == y.Key && y.Value == x.Value;
            }

            public int GetHashCode(KeyValuePair<int, int> obj)
            {
                return obj.Key*31 + obj.Value;
            }
        }  
    }
}
