﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Interfaces
{
    public interface IDrawingArea : IPaintToolsCollection
    {
        void Redraw();

        IDragAndDropPoint DragDropPoint(int x, int y);
    }
}
