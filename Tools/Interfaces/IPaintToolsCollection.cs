using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Interfaces
{
    public interface IPaintToolsCollection : IEnumerable<IPaintTool>
    {
        void Add(IPaintTool paintTool);
        IPaintTool Current { get; }
        void Clear();
    }
}
