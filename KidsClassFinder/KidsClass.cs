using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClassFinder

{ 

    public enum City
    {
        Redmond,
        Sammammish,
        Bellevue,
        Kirkland,
        Issaquah
    }

    public enum Timeframe
    {
        Spring,
        Summer,
        Fall,
        Winter,
        Yearround
    }

    public enum Type
    {
        Soccer,
        Swimming,
        Art,
        Dance,
        Gymnastics,
        Music
   }

    public enum Age
    {
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10      
    }
    class KidsClass
    {        

        #region Statics
       
        
        
        #endregion

        #region Properties
             
        public Timeframe Session { get; set; }
        public City Location { get; set; }
        public string Age { get; set; }
        public decimal Price { get; private set; }
        public string Address { get; set; }
        public int TotalSpots { get; private set; }
        public string Name { get; set; }
        public Type ClassType { get; set; }

        #endregion

        #region Methods

        public KidsClass( Timeframe clSession, City clLocation, string clAge, 
            decimal clPrice, string clAddress, int spotsTotal, string clName)
        {
            Session = clSession;
            Location = clLocation;
            Age = clAge;
            Price = clPrice;
            Address = clAddress;
            TotalSpots = spotsTotal;
            Name = clName;
        }
        #endregion


    }
}
