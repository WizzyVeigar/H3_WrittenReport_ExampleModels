﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_WrittenReport_Example.WeaponParts
{
    public class WeaponGrip : WeaponPart
    {
        public float BonusStability { get; set; }
        public WeaponGrip(Manufacturer man) : base(man)
        {
        }
    }
}
