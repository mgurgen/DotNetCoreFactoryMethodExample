using System;

namespace FactoryMethodRunner
{
    class App
    {
        IBlacksmith blacksmith;

        public App(IBlacksmith blacksmith)
        {
            this.blacksmith = blacksmith;
        }

        public void ManufactureWeapons()
        {
            IWeapon weapon;
            weapon = blacksmith.ManufactureWeapons(new WeaponType("Axe"));
        }
    }
}