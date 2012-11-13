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
    public sealed class OutputPanel : Panel
    {
        private readonly IList<IPaintTool> tools;
        private int zoom = 1;

        public OutputPanel(IList<IPaintTool> tools)
        {
            DoubleBuffered = true;
            this.tools = tools;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var proxyGraphics = new ProxyGraphics(g, zoom);
            foreach(var tool in tools)
                tool.Draw(proxyGraphics);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            tools.Last().OnMouseClicked(e.X / zoom, e.Y / zoom);
            Invalidate(true);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            tools.Last().OnMouseClick(e.X / zoom, e.Y / zoom);
            Invalidate(true);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            tools.Last().OnMouseMoved(e.X / zoom, e.Y / zoom);
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
            Invalidate(true);
            return zoom == 1;
        }
    }
}
