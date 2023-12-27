using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.SimpleFactoryPattern
{
    public abstract class Button
    {
        public int border { get; set; }

        public abstract void onClick();


        public abstract void render();
    }
}
