using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClassFinder
{
   

    class Program
    {
        static void Main(string[] args)
        {          

            Console.WriteLine("Please enter details to find classes closest to you");

            Console.WriteLine($"What type of class are you looking for? : "); // drop down menu 
            var classType = Console.ReadLine();
                   
            Console.WriteLine("Enter session: "); // drop down menu
            var session = Console.ReadLine();

            Console.WriteLine("What city do you prefer? : ");  //drop down menu
            var city = Console.ReadLine();

            Console.WriteLine("What ages are you looking for?"); //drop down menu
            var age = Console.ReadLine();

            Console.WriteLine($"Press any key to look for a {classType} class for age {age} in {city} for the {session}");
          
            Console.ReadLine();

            Console.WriteLine("Press any Key to check availablity");         

        }
    }
}
