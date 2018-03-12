using System;

namespace FactoryMethodRunner
{
    class ElfBlacksmith : IBlacksmith
    {
        public override string ToString()
        {
            return "Elf BlackSmith";
        }

        public IWeapon ManufactureWeapons(WeaponType weaponType)
        {
            return new ElfWeapon(weaponType);
        }
    }
}