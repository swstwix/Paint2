using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Interfaces;

namespace Tools
{
    public class PaintToolsCollection : List<IPaintTool>, IPaintToolsCollection
    {
        void IPaintToolsCollection.Add(IPaintTool paintTool)
        {
            Add(paintTool);
        }

        public IPaintTool Current
        {
            get
            {
                return this.Last();
            }
        }
    }
}
