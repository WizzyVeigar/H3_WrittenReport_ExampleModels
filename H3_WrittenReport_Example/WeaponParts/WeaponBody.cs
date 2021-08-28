using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_WrittenReport_Example.WeaponParts
{
    public class WeaponBody : WeaponPart
    {
        public int BonusAmmo { get; set; }
        public WeaponBody(Manufacturer man) : base(man)
        {
        }
    }
}
