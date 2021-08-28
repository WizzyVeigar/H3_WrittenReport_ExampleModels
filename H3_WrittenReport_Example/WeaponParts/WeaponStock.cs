using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_WrittenReport_Example.WeaponParts
{
    public class WeaponStock : WeaponPart
    {
        public float BonusAccuracy { get; set; }
        public WeaponStock(Manufacturer man) : base(man)
        {
        }
    }
}
