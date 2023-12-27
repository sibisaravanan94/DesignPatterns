using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactoryPattern
{
    public class LightRadioButton : RadioButton
    {
        public override void onClick()
        {
            throw new NotImplementedException();
        }

        public override void render()
        {
            throw new NotImplementedException();
        }
    }
}
