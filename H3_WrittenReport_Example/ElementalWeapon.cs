using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_WrittenReport_Example
{
    public abstract class ElementalWeapon : BaseWeapon, IAddElemental
    {
        private ElementalType elementalType;
        public ElementalType ElementalType
        {
            get { return elementalType; }
            set { elementalType = value; }
        }


        private float chanceToApply;
        public float ChanceToApply
        {
            get { return chanceToApply; }
            set { chanceToApply = value; }
        }

        private float damagePerSecond;
        public float DamagePerSecond
        {
            get { return damagePerSecond; }
            set { damagePerSecond = value; }
        }

        public ElementalWeapon(Manufacturer man, int level, ElementalType type) : base(man, level)
        {
            ElementalType = type;
        }

    }
}
