using System;

namespace H3_WrittenReport_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseWeapon sniperRifle = new SniperRifle(Manufacturer.Jakobs, 50, ElementalType.Cryo);
        }
    }
}
