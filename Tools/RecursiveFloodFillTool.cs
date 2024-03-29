﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Threading.Tasks;
using Tools.Arguments;
using Tools.Helpers;
using Tools.Interfaces;

namespace Tools
{
    public class RecursiveFloodFillTool : IPaintTool
    {
        private int x0, y0;
        private bool afterClick = false;
        private IPixelSet pixelSet;
        private IList<Point> list;
        private Thread thread;
        private IDrawingArea drawingArea;
        private bool afterMove = false;

        public void OnMouseClick(int x, int y)
        {
            if (afterClick)
                return;
            afterClick = true;
            x0 = x;
            y0 = y;
        }

        public void OnMouseClicked(int x, int y)
        {
        }

        public void OnMouseMoved(int x, int y)
        {
        }

        public void Draw(IPixelSet pixelSet, IDrawingArea drawingArea)
        {
            this.pixelSet = pixelSet;
            this.drawingArea = drawingArea;
            if (afterClick)
                if (list == null)
                {
                    list = new List<Point>();
                    if (!afterMove)
                    {
                        thread = new Thread(Fill) {};
                        thread.Start();
                    }
                    else
                    {
                        Fill();
                        drawingArea.Redraw();
                    }
                }
                else
                {
                    DrawStack(pixelSet);
                }
        }

        public void Move(int x, int y)
        {
            x0 += x;
            y0 += y;
            afterClick = true;
            list = null;
            afterMove = true;
        }

        public void Rotate(int x, int y)
        {
            var newx0 = RotateHelper.RotateX(x0, y0, x, y);
            var newy0 = RotateHelper.RotateY(x0, y0, x, y);
            x0 = newx0;
            y0 = newy0;
            afterClick = true;
            list = null;
            afterMove = true;
        }

        public void Cutting(CuttingArguments cut)
        {
        }

        private void DrawStack(IPixelSet pixelSet)
        {
            lock (list)
                foreach (var item in list)
                    pixelSet.FillCell(item.X, item.Y);
        }

        public void Fill()
        {
            Fill(x0, y0);
        }

        public void Fill(int x, int y)
        {
            if (!pixelSet.CellIsInArea(x, y))
                return;
            if (pixelSet.IsNotFilled(x, y))
            {
                lock (list)
                    list.Add(new Point(x,y));
                pixelSet.AddPoint(x, y);
                if (!afterMove)
                {
                    drawingArea.Redraw();
                    thread.Join(5);
                }
            }
            else
                return;
            Fill(x + 1, y);
            Fill(x - 1, y);
            Fill(x, y + 1);
            Fill(x, y - 1);
        }
    }
}
