using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace H3_WrittenReport_Example
{
    public class WeaponManager
    {
        internal void SaveWeapons(List<BaseWeapon> weapons)
        {
            using (WeaponContext context = new WeaponContext())
            {
                //foreach (BaseWeapon weapon in weapons)
                //{
                //    if (weapon is Pistol)
                //    {
                //        context.Pistols.Add((Pistol)weapon);
                //    }
                //    else if(weapon is SniperRifle)
                //    {
                //        context.SniperRifles.Add((SniperRifle)weapon);
                //    }
                //    else
                //    {
                //        context.AssaultRifles.Add((AssaultRifle)weapon);
                //    }
                //}

                context.BaseWeapons.AddRange(weapons);
                context.SaveChanges();
            }
        }
    }
}
