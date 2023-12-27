using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.PrototypePattern
{
    // Step 1 -> Create interface
    public interface IGraphicalObject
    {
        IGraphicalObject Clone();
    }
}
