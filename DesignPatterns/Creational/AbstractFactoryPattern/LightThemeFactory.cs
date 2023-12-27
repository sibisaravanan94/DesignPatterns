using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactoryPattern
{
    public class LightThemeFactory : IThemeFactory
    {
        public Button createButton()
        {
            return new lightButton();
        }

        public Dropdown CreateDropdown()
        {
            return new LightDropdown();
        }

        public RadioButton createRadioButton()
        {
            return new LightRadioButton();
        }
    }
}
