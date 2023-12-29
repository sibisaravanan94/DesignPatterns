using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.DecoratorPattern
{
    public abstract class BaseDecorator : IDataSource
    {
        public BaseDecorator(IDataSource dataSource)
        {
            this.nextLayer = dataSource;
        }
        public IDataSource nextLayer;
        public abstract string read();

        public abstract void write(string data);
    }
}
