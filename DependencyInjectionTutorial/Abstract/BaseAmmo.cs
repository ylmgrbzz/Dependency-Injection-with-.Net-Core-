using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTutorial.Abstract
{
    public abstract class BaseAmmo : IAmmo
    {
        protected double power;
        public void Fire()
        {
            Console.WriteLine("power : " + power + "\tBase Ammo Fired");
        }
    }
}
