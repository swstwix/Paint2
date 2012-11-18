using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Interfaces;

namespace Tools.Decorators
{
    public abstract class AbstractPaintToolDecorator : IPaintTool 
    {
        protected readonly IPaintTool PaintTool;

        protected AbstractPaintToolDecorator(IPaintTool paintTool)
        {
            this.PaintTool = paintTool;
        }

        public virtual void OnMouseClick(int x, int y)
        {
            PaintTool.OnMouseClick(x, y);
        }

        public virtual void OnMouseClicked(int x, int y)
        {
            PaintTool.OnMouseClicked(x, y);
        }

        public virtual void OnMouseMoved(int x, int y)
        {
            PaintTool.OnMouseMoved(x, y);
        }

        public virtual void Draw(IPixelSet pixelSet, IDrawingArea drawingArea)
        {
            PaintTool.Draw(pixelSet, drawingArea);
        }
    }
}
