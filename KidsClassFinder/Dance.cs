﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClassFinder
{
    class Dance : KidsClass
    {
        public Dance (Type clType, Timeframe clSession, City clLocation, string clAge, decimal clPrice,
            string clAddress, int spotsTotal, string clName) : base(clSession, clLocation, clAge, clPrice, clAddress, spotsTotal, clName)
        {
        }
    }
}