using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint2;

namespace Paint2
{
    public class DragAndDropHelper
    {

        internal static bool Need(DragAndDropPoint p, MouseEventArgs e)
        {
            int dx = p.X - e.X;
            int dy = p.Y - e.Y;

            return Math.Abs(dx)*Math.Abs(dx) + Math.Abs(dy)*Math.Abs(dy) < 100;
        }
    }
}
