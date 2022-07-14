using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryController
    {
        
        public List<Country> CountryDb { get; set; }
        public void CountryAction(Country c)
        {
            CountryView chungus = new CountryView(c);
            chungus.Display();
        }

        public void WelcomeAction()
        {
            bool isrunning = true;
            while (isrunning)
            {


                CountryListView countryList = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
                countryList.Display();
                Console.WriteLine("Please select a country (enter the associated number)");
                int choice = int.Parse(Console.ReadLine().Trim());
                CountryAction(CountryDb[choice]);
                Console.WriteLine("Would you like to learn about another country? (y/n)");
                if(Console.ReadLine().ToLower().Trim() == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Have a great day! Thank you for using this app.");
                    isrunning = false;
                    break;
                }
            }
        }
        public CountryController()
        {
            CountryDb = new List<Country>()
        {
            new Country("Japan","Asia",new List<string>{"Red","White"}),
            new Country("China","Asia",new List<string>{"Red","Yellow"}),
            new Country("South Korea","Asia",new List<string>{"Red","White","Blue","Black"}),
            new Country("USA","America",new List<string>{"Red","White","Blue"}),
            new Country("Canada","America",new List<string>{"Red","White"}),
            new Country("Poland","Europe",new List<string> { "Red", "White" }),
            new Country("United Kingdom","Europe", new List<string> { "Red", "White","Blue" }),
            new Country("Albania","Europe",new List<string>{"Red","Black"}),
            new Country("Ireland","Europe",new List<string>{"Green","White","Orange"}),
            new Country("Morocco","Africa",new List<string>{"Red","Green"})
        };
        }
    }
}
