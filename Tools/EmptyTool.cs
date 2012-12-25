using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Arguments;
using Tools.Interfaces;

namespace Tools
{
    public class EmptyTool : IPaintTool
    {

        public void OnMouseClick(int x, int y)
        {
        }

        public void OnMouseClicked(int x, int y)
        {
        }

        public void OnMouseMoved(int x, int y)
        {
        }

        public void Draw(IPixelSet pixelSet, IDrawingArea drawingArea)
        {
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
