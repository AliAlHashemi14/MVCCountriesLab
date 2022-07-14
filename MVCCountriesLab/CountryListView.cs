using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryListView
    {
        //props
        public List<Country> Countries { get; set; }
        //constructor
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        //methods
        public void Display()
        {
            foreach(Country c in Countries)
            {
                Console.WriteLine($"{Countries.IndexOf(c)}. {c.Name}");
            }
        }

    }
}
