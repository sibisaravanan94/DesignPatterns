using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.DecoratorPattern
{
    public interface IDataSource
    {
        void write(string data);
        string read();
    }
}
