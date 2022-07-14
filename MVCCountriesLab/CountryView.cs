using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryView
    {
        //props
        public Country DisplayCountry { get; set; }
        //constructor
        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }


        //methods
        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent} \nCountry Colors: ");
            foreach(string color in DisplayCountry.Colors)
            {
                SetForegroundColor(color);
                Console.WriteLine(color);
                Console.ResetColor();
            }
        }

        public static void SetForegroundColor(string colorName)
        {
            //Set black as foreground color if TryParse fails to parse color string. 
            if (Enum.TryParse(colorName, out ConsoleColor color))
            {
                Console.ForegroundColor = color;
                if(color == ConsoleColor.Black)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
            }

        }

    }
}
