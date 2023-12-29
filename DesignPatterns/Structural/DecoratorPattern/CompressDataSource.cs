using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.DecoratorPattern
{
    public class CompressDataSource : BaseDecorator
    {
        public CompressDataSource(IDataSource nextLayer) : base(nextLayer)
        {

        }
        public override string read()
        {
            string data = nextLayer.read();
            return decompress(data);
        }

        private string decompress(string data)
        {
            return data += " - Decompressed ";
        }

        public override void write(string data)
        {
            data += " - Compressed";
            nextLayer.write(data);
        }
    }
}
