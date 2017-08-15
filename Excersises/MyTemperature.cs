using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersises
{
    /*****************************
 * Skapad av Gustav Themer
 * 
 * gustav@themer.se
 * 
 * ***************************/
    class MyTemperature
    {
        //Metod för att konvertera celcius till fahrenheit, men en överlagring
        public static int CelsiusToFahrenheit(int celcius)
        {
            return Convert.ToInt32(CTF(celcius));
        }
        public static float CelsiusToFahrenheit(float celcius)
        {
            return CTF(celcius);
        }
        //Metod för att konvertera fahrenheit till celcius, med en överlagring
        public static int FahrenheitToCelcius(int fahrenheit)
        {
            return Convert.ToInt32(FTC(fahrenheit));
        }
        public static float FahrenheitToCelcius(float fahrenheit)
        {
            return FTC(fahrenheit);
        }

        //Metod för uträkningar
        //Jag tycker det är bättre att lägga uträkningarna i de publika metoderna. I och med att 
        //det ska konvereras om mellan float och int så blir det bara onödigt krångligt att göra så här.
        //Eller har jag tänkt fel?
        static float CTF(float celcius)
        {
            return ((celcius * 9) / 5) + 32;
        }
        static float FTC(float fahrenheit)
        {
            return ((fahrenheit - 32) * 5) / 9;
        }
    }
}
