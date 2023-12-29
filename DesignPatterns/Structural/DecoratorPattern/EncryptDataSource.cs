using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.DecoratorPattern
{
    public class EncryptDataSource : BaseDecorator
    {
        public EncryptDataSource(IDataSource nextLayer) : base(nextLayer)
        {
            
        }
        public override string read()
        {
            string data = nextLayer.read();
            return decrypt(data);
        }

        private string decrypt(string data)
        {
            return data += " - decrypted ";
        }

        public override void write(string data)
        {
            data += " - encrypted";
            nextLayer.write(data);
        }
    }
}
