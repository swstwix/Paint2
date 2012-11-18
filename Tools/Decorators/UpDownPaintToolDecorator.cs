using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Interfaces;

namespace Tools.Decorators
{
    public class UpDownPaintToolDecorator : AbstractPaintToolDecorator
    {
        private bool afterMouseClick = false;
        private bool afterMouseClicked = false;

        public UpDownPaintToolDecorator(IPaintTool paintTool) : base(paintTool)
        {
        }

        public override void OnMouseClick(int x, int y)
        {
            if (afterMouseClick)
                return;
            base.OnMouseClick(x, y);
            afterMouseClick = true;
        }

        public override void OnMouseMoved(int x, int y)
        {
            if (afterMouseClicked)
                return;
            base.OnMouseMoved(x, y);
        }

        public override void OnMouseClicked(int x, int y)
        {
            if (afterMouseClicked)
                return;
            base.OnMouseClicked(x, y);
            afterMouseClicked = true;
        }

        public override void Draw(IPixelSet pixelSet, IDrawingArea drawingArea)
        {
            if (!afterMouseClick)
                return;
            base.Draw(pixelSet, drawingArea);
        }
    }
}
