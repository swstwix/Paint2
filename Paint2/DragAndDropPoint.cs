using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Interfaces;

namespace Paint2
{
    public class DragAndDropPoint : IDragAndDropPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
