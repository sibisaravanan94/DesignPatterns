using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.PrototypePattern
{
    public sealed class BackgroundObjectRegistry
    {
        Dictionary<BackgroundObjectType, BackgroundObject> registry = new Dictionary<BackgroundObjectType, BackgroundObject>();

        private static BackgroundObjectRegistry objReg = null;
        public static readonly object obj = new object();

        private BackgroundObjectRegistry()
        {

        }

        public static BackgroundObjectRegistry getInstance()
        {
            if(objReg == null)
            {
                lock (obj)
                {
                    if (objReg == null)
                    {
                        objReg = new BackgroundObjectRegistry();
                    }
                }
            }

            return objReg;
        }
        public void register(BackgroundObject obj)
        {
            registry.Add(obj.type, obj);
        }

        public void unRegister(BackgroundObjectType type)
        {
            registry.Remove(type);
        }

        public BackgroundObject getPrototype(BackgroundObjectType type)
        {
            return registry[type];
        }
    }
}
