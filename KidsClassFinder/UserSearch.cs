using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClassFinder
{
    class UserSearch

    {
        // public virtual KidsClass KidsClass { get; set; }
        
       //  public virtual ICollection<KidsClass> KidsClasses { get; set; }

      
        
      public IQueryable<KidsClass> Search(ClassType clType, Timeframe clSession, City clLocation, int clAge)
      {
            List<KidsClass> listOfClassesToReturn = new List<KidsClass>();
            KidsClassModel db = new KidsClassModel();

            return db.KidsClasses.Where(k => k.Location == clLocation && k.Session == clSession && k.ClsType == clType)
                .Where(k => k.Age == clAge);
            foreach (var kidsClass in db.KidsClasses.Where(k => k.Location == clLocation && k.Session == clSession && k.ClsType == clType)
                .Where(k => k.Age == clAge))           
                
            {
                listOfClassesToReturn.Add(kidsClass);
                //Console.WriteLine($"We found {kidsClass.Name} at {kidsClass.Address} that matches your requirements");

            }
              
        }
      



    }
}
