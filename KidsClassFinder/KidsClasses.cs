using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClassFinder
{
    class KidsClasses
    {
        #region Statics
        // This is to let the user know how many spots are currently available in a particular class. 
        //As more people sign up the number should progressively reduce

        private static int AvailabilityNumber = 10;
        
        #endregion

        #region Properties

        public string Type { get; set; }
        public string Session { get; set; }
        public string LocationCity { get; set; }
        public string ForAges { get; set; }
        public decimal Price { get; private set; }
        public string Address { get; set; }
        public int Availability { get; private set; }
        #endregion


        #region Methods
        //Constructor for Availability
        public KidsClasses()
        {
            this.Availability = AvailabilityNumber++;
                }

        // still figuring out more methods
        public string EnterType(string Summer, string Spring)
        {
            return Type;
        }

        #endregion


    }
}
