using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Helpers
{
    public class RotateHelper
    {
        public static int RotateX(int x, int y, int x0, int y0)
        {
            double angle = Math.PI/3;
            double dx = x - x0;
            double dy = y - x0;
            return (int)(x0 + dx * Math.Cos(angle) - dy*Math.Sin(angle));
        }

        public static int RotateY(int x, int y, int x0, int y0)
        {
            double angle = Math.PI / 3;
            double dx = x - x0;
            double dy = y - y0;
            return (int)(y0 + dx * Math.Sin(angle) + dy * Math.Cos(angle));
        }
    }
}
