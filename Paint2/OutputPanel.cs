using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools.Interfaces;

namespace Paint2
{
    public sealed class OutputPanel : Panel, IDrawingArea
    {
        private int zoom = 1;
        private readonly IPaintToolsCollection paintTools;
        private readonly IList<DragAndDropPoint> dragAndDropPoints;
        private readonly IList<DragAndDropPoint> dragAndDropActivePoints;
        private int dragAndDropX0;
        private int dragAndDropY0;
        private int dragAndDropY1;
        private int dragAndDropX1;

        public OutputPanel(IPaintToolsCollection paintToolsCollection)
        {
            this.DoubleBuffered = true;
            this.paintTools = paintToolsCollection;
            dragAndDropPoints = new List<DragAndDropPoint>();
            dragAndDropActivePoints = new List<DragAndDropPoint>();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var proxyGraphics = new ProxyPixelSet(g, zoom, Width, Height);
            foreach (var tool in paintTools)
                tool.Draw(proxyGraphics, this);
            foreach (var p in dragAndDropPoints)
            {
                g.DrawEllipse(Pens.Black, p.X - 5, p.Y - 5, 10, 10);
            }
            g.DrawEllipse(Pens.Violet, Width/2 + 10, Height/2 + 10, 10, 10);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                dragAndDropX1 = e.X;
                dragAndDropY1 = e.Y;
                foreach (var p in dragAndDropActivePoints)
                {
                    p.X += dragAndDropX1 - dragAndDropX0;
                    p.Y += dragAndDropY1 - dragAndDropY0;
                }
                dragAndDropActivePoints.Clear();
            }

            paintTools.Current.OnMouseClicked(e.X / zoom, e.Y / zoom);
            Invalidate(true);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                dragAndDropX0 = e.X;
                dragAndDropY0 = e.Y;
                foreach (var p in dragAndDropPoints)
                {
                    if (DragAndDropHelper.Need(p,e))
                        dragAndDropActivePoints.Add(p);
                }
            }
            paintTools.Current.OnMouseClick(e.X / zoom, e.Y / zoom);
            Invalidate(true);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                dragAndDropX1 = e.X;
                dragAndDropY1 = e.Y;
            }
            paintTools.Current.OnMouseMoved(e.X / zoom, e.Y / zoom);
            Invalidate(true);
        }

        public bool IncZoom()
        {
            zoom++;
            Width = Width*zoom/(zoom - 1);
            Height = Height * zoom / (zoom - 1);
            return zoom == 8;
        }

        public bool DecZoom()
        {
            zoom--;
            Width = Width * zoom / (zoom + 1);
            Height = Height * zoom / (zoom + 1);
            return zoom == 1;
        }

        public void Redraw()
        {
            Invalidate(false);
        }

        public IDragAndDropPoint DragDropPoint(int x, int y)
        {
            var newIns = new DragAndDropPoint() {X = x, Y = y};
            dragAndDropPoints.Add(newIns);
            return newIns;
        }

        public IEnumerator<IPaintTool> GetEnumerator()
        {
            return paintTools.GetEnumerator();
        }

        public void Add(IPaintTool paintTool)
        {
            paintTools.Add(paintTool);
        }

        public IPaintTool Current { get; private set; }

        public void Clear()
        {
            paintTools.Clear();
            dragAndDropPoints.Clear();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
