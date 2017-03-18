using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClassFinder
{
    class UserSearch

    {
        public virtual KidsClass KidsClass { get; set; }

        public virtual ICollection<KidsClass> KidsClasses { get; set; }


        
      public KidsClass Search(ClassType clType, Timeframe clSession, City clLocation, int clAge)
      {
            var db = new KidsClassModel();

            foreach (var kidsClass in db.KidsClasses.Where(k => k.Location == clLocation).Where(k => k.Session == clSession).Where(k => k.ClsType == clType)
                .Where(k => k.Age == clAge))             
                
            {
                Console.WriteLine($"We found {KidsClass.Name} at {KidsClass.Address} that matches your requirements");
            }

            return KidsClass;
      }
      



    }
}
