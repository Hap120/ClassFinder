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

            Console.WriteLine($"What type of class are you looking for? : 1.Soccer  2.Gymnastics 3.Swimming  4.Music  5.Art"); // drop down menu 
            string classType = Console.ReadLine();
            ClassType classTypeToSearch = ClassType.Soccer;          

                switch (classType)
            {
                case "1":
                    classTypeToSearch = ClassType.Soccer;
                    break;
                case "2":
                    classTypeToSearch = ClassType.Gymnastics;
                    break;
                case "3":
                    classTypeToSearch = ClassType.Swimming;
                    break;
                case "4":
                    classTypeToSearch = ClassType.Music;
                    break;
                case "5":
                    classTypeToSearch = ClassType.Art;
                    break;
                default:
                    Console.WriteLine("Please enter a valid type of class");                   
                    break;                     
            }

                   
            Console.WriteLine("Enter session : 1.Spring 2.Summer 3.Fall  4.Winter "); // drop down menu
            string session = Console.ReadLine();
            Timeframe sessionToSearch = Timeframe.Yearround;

            switch (session)
            {
                case "1":
                    sessionToSearch = Timeframe.Spring;
                    break;
                case "2":
                    sessionToSearch = Timeframe.Summer;
                    break;
                case "3":
                   sessionToSearch = Timeframe.Fall;
                    break;
                case "4":
                   sessionToSearch = Timeframe.Winter;
                    break;
                default:
                    Console.WriteLine("Please enter a valid session");
                    break;
            }

            Console.WriteLine("What city do you prefer? :  1.Redmond, 2.Sammammish  3.Bellevue  4.Issaquah  5.Kirkland");  //drop down menu
            string city = Console.ReadLine();
            City cityToSearch = City.Bellevue;

            switch(city)
            {
                case "1":
                    cityToSearch = City.Redmond;
                    break;
                case "2":
                    cityToSearch = City.Sammammish;
                    break;
                case "3":
                    cityToSearch = City.Bellevue;
                    break;
                case "4":
                    cityToSearch = City.Issaquah;
                    break;
                case "5":
                    cityToSearch = City.Kirkland;
                    break;
                default:
                    Console.WriteLine("Please enter a city");
                    break;
            }

            Console.WriteLine("What ages are you looking for? : 5, 6, 7, 8, 9, 10"); //drop down menu
            int ageToSearch = int.Parse(Console.ReadLine());
            

            Console.WriteLine($"Press any key to look for a {classTypeToSearch} class for age {ageToSearch} in {cityToSearch} for the {sessionToSearch}");
          
            Console.ReadLine();

            UserSearch temp = new UserSearch();
            temp.Search(classTypeToSearch, sessionToSearch, cityToSearch, ageToSearch);


            ClassesList db1 = new ClassesList();
            db1.PopulateDb();

          


            /*
              foreach (var item in collection)
            {

            }
            

            

            
            Console.WriteLine($"We found {kidsClass.Name} at {kidsClass.Address} that matches your requirements");

            Console.WriteLine("Press any Key to check availablity");         
*/
        }
    }
}
