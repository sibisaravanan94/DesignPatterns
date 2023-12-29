using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.FlyWeightPattern
{
    public sealed class BulletRegistry
    {
        Dictionary<BullerType, Bullet> registry = new Dictionary<BullerType, Bullet>();

        private static BulletRegistry objReg = null;
        public static readonly object obj = new object();

        private BulletRegistry()
        {

        }

        public static BulletRegistry getInstance()
        {
            if(objReg == null)
            {
                lock (obj)
                {
                    if (objReg == null)
                    {
                        objReg = new BulletRegistry();
                    }
                }
            }

            return objReg;
        }
        public void register(Bullet obj)
        {
            registry.Add(obj.type, obj);
        }

        public void unRegister(BullerType type)
        {
            registry.Remove(type);
        }

        public Bullet getBullet(BullerType type)
        {
            return registry[type];
        }
    }
}
