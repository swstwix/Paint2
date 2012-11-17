using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Interfaces;

namespace Tools
{
    public class EllipseTool : IPaintTool
    {
        private int x, y;
        private int a, b;
        private bool afterMouseClick = false;
        private bool afterMouseClicked = false;

        public void OnMouseClick(int xm, int ym)
        {
            if (afterMouseClicked)
                return;
            x = xm;
            y = ym;
            a = 0;
            b = 0;
            afterMouseClick = true;
        }

        public void OnMouseClicked(int xm, int ym)
        {
            if (afterMouseClicked)
                return;
            a = Math.Abs(x - xm);
            b = Math.Abs(y - ym);
            afterMouseClicked = true;
        }

        public void OnMouseMoved(int xm, int ym)
        {
            if (afterMouseClicked)
                return;
            a = Math.Abs(x - xm);
            b = Math.Abs(y - ym);
        }

        public void Draw(IPixelSet pixelSet)
        {
            if (!afterMouseClick)
                return;
            int col, i, row, bnew;
            long a_square, b_square, two_a_square, two_b_square, four_a_square, four_b_square, d;

            b_square = b * b;
            a_square = a * a;
            row = b;
            col = 0;
            two_a_square = a_square << 1;
            four_a_square = a_square << 2;
            four_b_square = b_square << 2;
            two_b_square = b_square << 1;
            d = two_a_square * ((row - 1) * (row)) + a_square + two_b_square * (1 - a_square);
            while (a_square * (row) > b_square * (col))
            {
                PutPixel(pixelSet, col + x, row + y);
                PutPixel(pixelSet, col + x, y - row);
                PutPixel(pixelSet, x - col, row + y);
                PutPixel(pixelSet, x - col, y - row);
                if (d >= 0)
                {
                    row--;
                    d -= four_a_square * (row);
                }
                d += two_b_square * (3 + (col << 1));
                col++;
            }
            d = two_b_square * (col + 1) * col + two_a_square * (row * (row - 2) + 1) + (1 - two_a_square) * b_square;
            while ((row + 1) > 0)
            {
                PutPixel(pixelSet, col + x, row + y);
                PutPixel(pixelSet, col + x, y - row);
                PutPixel(pixelSet, x - col, row + y);
                PutPixel(pixelSet, x - col, y - row);
                if (d <= 0)
                {
                    col++;
                    d += four_b_square * col;
                }
                row--;
                d += two_a_square * (3 - (row << 1));
            }
        }

        private void PutPixel(IPixelSet g, int x, int y)
        {
            if (!afterMouseClicked)
                g.DrawPreviewPixel(x, y);
            else
                g.DrawPixel(x, y);
        }
    }
}
