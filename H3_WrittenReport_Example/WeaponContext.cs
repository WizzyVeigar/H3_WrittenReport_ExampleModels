using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_WrittenReport_Example
{
    class WeaponContext : DbContext
    {
        public DbSet<BaseWeapon> BaseWeapons { get; set; }
        //public DbSet<Pistol> Pistols { get; set; }
        //public DbSet<SniperRifle> SniperRifles { get; set; }
        //public DbSet<AssaultRifle> AssaultRifles { get; set; }

        public WeaponContext() : base()
        {

        }
    }
}
