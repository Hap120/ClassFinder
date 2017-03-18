﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClassFinder
{
    class ClassesList
    {


        /* public List<KidsClass> AllClasses { get; set; }

          public void PopulateList()
          {
              AllClasses.Add(new Soccer(Timeframe.Fall, City.Redmond,
                 9 , 30, "120 NE 85th st", 10, "Arena Soccer"));
              AllClasses.Add(new Swimming(Timeframe.Summer, City.Sammammish,
                  5, 100, "3400 160th Ave NE", 5, "YMCA Swimming"));
          }

        */

        public void PopulateDb()
        {
            var db = new KidsClassModel();
            db.KidsClasses.Add(new Soccer(Timeframe.Fall, City.Bellevue, 7, 100, "120 Bellevue Way", 10, "Bellevue Soccer"));
            db.KidsClasses.Add(new Soccer(Timeframe.Fall, City.Redmond,
                 9, 30, "120 NE 85th st", 10, "Arena Soccer"));
            db.KidsClasses.Add(new Swimming(Timeframe.Summer, City.Sammammish,
                5, 100, "3400 160th Ave NE", 5, "YMCA Swimming"));
            db.SaveChanges();
        }

        
    }
}
