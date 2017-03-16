using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClassFinder
{
    class ClassesList
    {
        public List<KidsClass> AllClasses { get; set; }

        public void PopulateList()
        {
            AllClasses.Add(new Soccer(Type.Soccer, Timeframe.Fall, City.Redmond,
                "6,7,8,9,10", 30M, "120 NE 85th st", 10, "Arena Soccer"));
            AllClasses.Add(new Swimming(Type.Swimming, Timeframe.Summer, City.Sammammish,
                "4,5", 100M, "3400 160th Ave NE", 5, "YMCA Swimming"));
        }

        public void Search(Type clType, Timeframe clSession, City clLocation, string clAge)
        {
             
        }
    }
}
