using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_WrittenReport_Example.WeaponParts
{
    public class WeaponBody
    {
        public Manufacturer Manufacturer { get; protected set; }

        public WeaponBody(Manufacturer man)
        {
            Manufacturer = man;
        }
    }
}
