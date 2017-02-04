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
           /* KidsClasses myClass = new KidsClasses();
            myClass.Type = "Sports";
            myClass.Session = "Summer";
            myClass.ForAges = "10";
            myClass.LocationCity = "Redmond";
            Console.WriteLine($"Look for a {myClass.Type} class for age {myClass.ForAges} in {myClass.LocationCity} for the {myClass.Session}");
            */

            //Questions:
            //Which of the two is more suitable for user entering information? The approach above ^ or the one following the comments ?

            Console.WriteLine("Please enter details to find classes closest to you");
            Console.WriteLine("What type of class are you looking for? : Sports/Art/Dance");
            //Planning to put an if statement here .. for now I only have the following progression sports-soccer-session-city-ages
            var Sports = Console.ReadLine();
            Console.WriteLine("Choose an option: Soccer,  Swimming, Football ");
            var SportType = Console.ReadLine();
                   
            Console.WriteLine("Enter session: Summer, Spring, Fall, Winter");
            var session = Console.ReadLine();

            Console.WriteLine("What city do you prefer? : Sammamish, Redmond, Bellevue");
            var city = Console.ReadLine();

            Console.WriteLine("What ages are you looking for?");
            var age = Console.ReadLine();

            Console.WriteLine($"Please wait until we look for a {SportType} class for age {age} in {city} for the {session}");
             

           // Console.WriteLine($"The following classes meet your requirement: {A}, {B}, {C}");
            //Can this placeholder info will be pulled from the array in ClaasDatabases.cs for now ?
            var userInput = Console.ReadLine();

            //Should I have separate classes for different kinds of Sports or can I have subclasses ?

            Console.WriteLine("Press any Key to check availablity");

            

        }
    }
}
