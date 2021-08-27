using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_WrittenReport_Example
{
    public enum ElementalType
    {
        Fire,
        Cryo,
        Corrosive,
        Shock
    }
    interface IAddElemental
    {
        public ElementalType ElementalType { get; }
        public float ChanceToApply { get; }
        public float DamagePerSecond { get; }

    }
}
