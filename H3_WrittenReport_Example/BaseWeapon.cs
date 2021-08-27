using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_WrittenReport_Example
{
    public enum Manufacturer
    {
        Torgue,
        Maliwan,
        Jakobs
    }

    public abstract class BaseWeapon
    {
        [Key]
        public int WeaponId { get; set; }
        public string Name { get; set; }

        public Manufacturer Manufacturer { get; protected set; }

        public float MinDamage { get; set; }

        public float MaxDamage { get; set; }

        public int Level { get; protected set; }

        public BaseWeapon(Manufacturer man, int level)
        {
            Manufacturer = man;
            Level = level;
        }

        public BaseWeapon()
        {

        }
    }
}
