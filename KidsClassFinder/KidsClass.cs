using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    public enum ClassType
    {
        Soccer,
        Swimming,
        Art,
        Dance,
        Gymnastics,
        Music
   }

     
    class KidsClass
    {        

        #region Statics
       
        
        
        #endregion

        #region Properties
        [Key]
             
        public Timeframe Session { get; set; }
        public City Location { get; set; }
        public int Age { get; set; }
        public double Price { get; private set; }
        public string Address { get; set; }
        public int TotalSpots { get; private set; }
        public string Name { get; set; }
        public ClassType ClsType { get; set; }

        
        #endregion

        #region Methods

        public KidsClass( ClassType clType, Timeframe clSession, City clLocation, int clAge, 
            double clPrice, string clAddress, int spotsTotal, string clName)
        {
            ClsType = clType;
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
