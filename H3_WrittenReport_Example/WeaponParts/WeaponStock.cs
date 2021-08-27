using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_WrittenReport_Example.WeaponParts
{
    public class WeaponStock
    {
        public Manufacturer Manufacturer { get; protected set; }

        public WeaponStock(Manufacturer man)
        {
            Manufacturer = man;
        }
    }
}
