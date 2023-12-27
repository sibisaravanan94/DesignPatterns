using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactoryPattern
{
    public interface IThemeFactory
    {
        Button createButton();
        RadioButton createRadioButton();
        Dropdown CreateDropdown();
    }
}
