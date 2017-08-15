using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*****************************
 * Skapad av Gustav Themer
 * 
 * gustav@themer.se
 * 
 * ***************************/

namespace Excersises
{
    static class ChapterEight
    {
        //Metoden löser övning 8.1
        public static void Temperature()
        {
            int temperature = 0;
            int tmpTemperature;
            string input;
            do
            {
                Console.WriteLine($"Temperaturen är {temperature} grader celcius.");
                Console.Write("Mata in temperatur: ");
                input = Console.ReadLine();
                if(input == "q" || input == "Q")
                {
                    break;
                }
                else
                {
                    tmpTemperature = Convert.ToInt32(input);
                    if(tmpTemperature < 17)
                    {
                        temperature = 20;
                    }
                    else
                    {
                        if(tmpTemperature > 25)
                        {
                            temperature = 20;
                        }
                    }
                }
            } while (true);
        }
    }
}
