using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClassFinder
{
    class Soccer : KidsClass
    {
          public Soccer (
              Timeframe clSession, City clLocation,
              int clAge, double clPrice,
              string clAddress, int spotsTotal, string clName)
            : base(
                  clSession,
                  clLocation,
                  clAge,
                  clPrice,
                  clAddress,
                  spotsTotal, clName)
        {
        }
        

    }
}
