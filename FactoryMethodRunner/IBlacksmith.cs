using System;

namespace FactoryMethodRunner
{
    interface IBlacksmith
    {
        IWeapon ManufactureWeapons(WeaponType weaponType);
    }
}