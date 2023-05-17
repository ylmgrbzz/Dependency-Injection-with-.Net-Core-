using DependencyInjectionTutorial.Concrete;
using System;

namespace DependencyInjectionTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            XAmmo xAmmo = new XAmmo();
            YAmmo yAmmo = new YAmmo();

            xAmmo.Fire();
            yAmmo.Fire();
        }
    }
}