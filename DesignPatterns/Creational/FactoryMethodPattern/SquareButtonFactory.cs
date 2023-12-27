using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethodPattern
{
    public class SquareButtonFactory : IButtonFactory
    {
        public Button createButton()
        {
            return new SquareButton();
        }
    }
}
