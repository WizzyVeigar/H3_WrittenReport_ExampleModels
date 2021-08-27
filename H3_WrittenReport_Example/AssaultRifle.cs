using H3_WrittenReport_Example.WeaponParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_WrittenReport_Example
{
    class AssaultRifle : ElementalWeapon
    {
        public WeaponGrip Grip { get; set; }
        public WeaponBarrel Barrel { get; set; }
        public WeaponStock Stock { get; set; }
        public AssaultRifle(Manufacturer man, int level, ElementalType type) : base(man, level, type)
        {
        }

        public AssaultRifle(WeaponGrip grip, WeaponBarrel barrel, WeaponStock stock,
            Manufacturer man, int level, ElementalType type) : this(man, level, type)
        {
            Grip = grip;
            Barrel = barrel;
            Stock = stock;
        }
    }
}
