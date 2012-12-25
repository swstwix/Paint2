using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Interfaces;

namespace Paint2
{
    class Comparer : IEqualityComparer<Point>
    {
        public bool Equals(Point x, Point y)
        {
            return (x.X == y.X) && (x.Y == y.Y);
        }

        public int GetHashCode(Point obj)
        {
            return 31 * obj.X + obj.Y;
        }
    }  

    public class ProxyPixelSet : IPixelSet
    {
        private readonly int zoom;
        private readonly Graphics graphics;
        private readonly int maxX;
        private readonly int maxY;
        private readonly HashSet<Point> hashSet;

        public ProxyPixelSet(Graphics g, int zoom, int width, int height)
        {
            this.zoom = zoom;
            this.graphics = g;
            maxX = width;
            maxY = height;
            hashSet = new HashSet<Point>(new Comparer());
        }

        public void DrawPixel(int x, int y)
        {
            hashSet.Add(new Point(x, y));
            graphics.FillRectangle(Brushes.Black, zoom * x, zoom * y, zoom, zoom);
        }

        public void DrawPreviewPixel(int x, int y)
        {
            hashSet.Add(new Point(x, y));
            graphics.FillRectangle(Brushes.Red, zoom * x, zoom * y, zoom, zoom);
        }

        public bool IsNotFilled(int x, int y)
        {
            return !hashSet.Contains(new Point() {X = x, Y = y});
        }

        public void FillCell(int x, int y)
        {
            hashSet.Add(new Point(x, y));
            graphics.FillRectangle(Brushes.Orange, zoom * x, zoom * y, zoom, zoom);
        }

        public bool CellIsInArea(int x, int y)
        {
            return (x >= 0) && (y >= 0) && (x*zoom < maxX) && (y*zoom < maxY);
        }

        public void AddPoint(int x, int y)
        {
            hashSet.Add(new Point(x, y));
        }
    }
}
