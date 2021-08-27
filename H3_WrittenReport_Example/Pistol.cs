using H3_WrittenReport_Example.WeaponParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_WrittenReport_Example
{
    public class Pistol : ElementalWeapon
    {
        public WeaponGrip Grip{ get; set; }
        public WeaponBarrel Barrel { get; set; }

        public Pistol(Manufacturer man, int level, ElementalType type) : base(man, level, type)
        {
        }
        public Pistol(WeaponGrip grip, WeaponBarrel barrel, Manufacturer man, int level, ElementalType type) : this(man, level, type)
        {
            Grip = grip;
            Barrel = barrel;
        }
    }
}
