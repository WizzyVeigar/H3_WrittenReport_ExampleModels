﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_WrittenReport_Example.WeaponParts
{
    public class WeaponBarrel : WeaponPart
    {
        public float BonusRecoil { get; set; }
        public WeaponBarrel(Manufacturer man) : base(man)
        {
        }
    }
}
