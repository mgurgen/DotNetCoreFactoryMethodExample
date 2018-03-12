namespace FactoryMethodRunner
{
    class ElfWeapon : IWeapon
    {
        WeaponType weaponType;

        public ElfWeapon(WeaponType weaponType)
        {
            this.weaponType = weaponType;
        }
        public WeaponType getWeaponType()
        {
            return weaponType;
        }
    }
}