using System;
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

        public OutputPanel(IPaintToolsCollection paintToolsCollection)
        {
            this.DoubleBuffered = true;
            this.paintTools = paintToolsCollection;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var proxyGraphics = new ProxyPixelSet(g, zoom, Width, Height);
            foreach (var tool in paintTools)
                tool.Draw(proxyGraphics, this);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            paintTools.Current.OnMouseClicked(e.X / zoom, e.Y / zoom);
            Invalidate(true);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            paintTools.Current.OnMouseClick(e.X / zoom, e.Y / zoom);
            Invalidate(true);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
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
    }
}
