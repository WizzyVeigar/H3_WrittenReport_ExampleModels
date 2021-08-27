using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace H3_WrittenReport_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseWeapon> weapons = GetWeapons();
            WeaponManager weaponManager = new WeaponManager();

            weaponManager.SaveWeapons(weapons);           

            Console.ReadLine();
        }


        public static List<BaseWeapon> GetWeapons()
        {
            BaseWeapon sniperRifle = new SniperRifle(Manufacturer.Jakobs, 50, ElementalType.Cryo)
            {
                Name = "Pimpernel",
                Barrel = new WeaponParts.WeaponBarrel(Manufacturer.Maliwan),
                Stock = new WeaponParts.WeaponStock(Manufacturer.Jakobs),
                Grip = new WeaponParts.WeaponGrip(Manufacturer.Jakobs),
                MinDamage = 4000,
                MaxDamage = 16000,
                DamagePerSecond = 150.2f,
                ChanceToApply = 60
            };
            BaseWeapon pistol = new Pistol(Manufacturer.Torgue, 10, ElementalType.None)
            {
                Barrel = new WeaponParts.WeaponBarrel(Manufacturer.Jakobs),
                Grip = new WeaponParts.WeaponGrip(Manufacturer.Torgue),
                MinDamage = 50,
                MaxDamage = 168.5f,
                Name = "Unkempt Herald"
            };

            List<BaseWeapon> weapons = new List<BaseWeapon>() { sniperRifle, pistol };

            return weapons;
        }
    }
}
