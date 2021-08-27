using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_WrittenReport_Example.WeaponParts
{
    public class WeaponGrip
    {
        public Manufacturer Manufacturer { get; protected set; }

        public WeaponGrip(Manufacturer man)
        {
            Manufacturer = man;
        }
    }
}
