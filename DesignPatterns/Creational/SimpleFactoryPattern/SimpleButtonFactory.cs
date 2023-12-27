using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.SimpleFactoryPattern
{
    public class SimpleButtonFactory
    {
        // Simple factory method
        // Violates SRP and OCP
        public Button createButton(ButtonType type)
        {
            if(type== ButtonType.rectangle)
            {
                return new RectangleButton();
            }
            else if (type == ButtonType.round)
            {
                return new RoundButton();
            }
            else
            {
                return new SquareButton();
            }
        }
    }
}
