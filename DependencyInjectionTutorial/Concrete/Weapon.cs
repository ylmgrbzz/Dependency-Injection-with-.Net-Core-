using DependencyInjectionTutorial.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTutorial.Concrete
{
    public class Weapon
    {
        private IAmmo _ammo;
        public Weapon(IAmmo ammo)
        {
            _ammo = ammo;

        }
        public void Fire()
        {
            _ammo.Fire();
        }
    }
}
