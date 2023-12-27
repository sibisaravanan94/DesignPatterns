using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactoryPattern
{
    public class DarkThemeFactory : IThemeFactory
    {
        public Button createButton()
        {
            return new DarkButton();
        }

        public Dropdown CreateDropdown()
        {
            return new DarkDropdown();
        }

        public RadioButton createRadioButton()
        {
            return new DarkRadioButton();
        }
    }
}
