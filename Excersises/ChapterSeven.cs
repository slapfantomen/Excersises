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
    static class ChapterSeven
    {
        public static void SumOfTwo()
        {
            int sum = 0;
            Console.WriteLine("Mata in två heltal.");
            for (int i = 0; i < 2; i++)
            {
                Console.Write(": ");
                sum += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Summan blir {sum}");
        }

        public static void SumAndAverageOfThree()
        {
            int sum = 0;
            Console.WriteLine("Mata in tre heltal.");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(": ");
                sum += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Summan blir {sum}, medelvärdet av talen blir {(float)sum / 3}");
        }
        public static void RoundAndDisplay()
        {
            Console.WriteLine("Mata in decimaltal");
            float floatNumber = float.Parse(Console.ReadLine());
            Console.WriteLine($"decimaltalet {floatNumber} avrundas till {Convert.ToInt32(floatNumber)}");
        }

        public static void ShortStory()
        {
            string firstName, secondName;
            Console.WriteLine("Mata in två namn.");
            Console.Write(": ");
            firstName = Console.ReadLine();
            Console.Write(": ");
            secondName = Console.ReadLine();
            Console.WriteLine($"Det var en gång en katt som hette {firstName}. Katten bodde hemma hos {secondName}." +
                $"Snipp, snapp, snut - så var sagan slut!");
        }

        public static void RoundToTwo()
        {
            Console.WriteLine("Mata in ett decimaltal med tre eller fler decimaler.");
            Console.Write(": ");
            float floatNumber = float.Parse(Console.ReadLine());
            Console.WriteLine($"decimaltalet {floatNumber} avrundat till två decimaler {Math.Round(floatNumber, 2)}");
        }

        //Metoden som löser övning 7.1.10
        public static void TwoSolutions()
        {
            int a = 1;
            int b = 2;

            //Första lösningen
            float c = (float)a / b;
            Console.WriteLine("Första lösningen");
            Console.WriteLine("float c = (float)a / b;");
            Console.WriteLine(c);

            //Andra lösningen
            c = 0;

            c = (float)a / (float)b;
            Console.WriteLine("Andra lösningen");
            Console.WriteLine("c = (float)a / (float)b;");
            Console.WriteLine(c);
        }
        //Den här metoden löser övningarna 7.3.1 -> 7.3.3
        public static void CheckWeather()
        {
            Console.WriteLine("Är det fint väder?");
            string input = Console.ReadLine();
            if(input == "j" || input == "J")
            {
                Console.WriteLine("Vi går på picknick!");
            }
            else if(input == "n" || input == "N")
            {
                Console.WriteLine("Vi stannar inne och läser en bok");
            }
            else
            {
                Console.WriteLine("Jag förstår inte");
            }     
        }
        //Metoden löser övningarna 7.3.4 och 7.3.5
        public static void WhereIsItTheColdest()
        {
            int arboga, amal, ostersund;
            Console.WriteLine("Mata in temperaturer (i heltal)");
            Console.Write("Arboga: ");
            arboga = Convert.ToInt32(Console.ReadLine());
            Console.Write("Åmål: ");
            amal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Östersund: ");
            ostersund = Convert.ToInt32(Console.ReadLine());
            if(ostersund < arboga && ostersund < amal)
            {
                Console.WriteLine("Det är kallast i Östersund");
            }
            else if (amal < arboga)
            {
                Console.WriteLine("Det är kallast i Åmal");
            }
            else
            {
                Console.WriteLine("Det är kallast i Arboga");
            }
        }
        //Metoden löser övningen 7.3.6
        public static void CorrectIfStatment()
        {
            int var = 10;
            Console.WriteLine("För att jämföra i en if-sats måste man använda två = tecken.");
            if(var == 10)
            {
                Console.WriteLine("den är 10");
            }
        }
        //Metoden löser övningen 7.4.2
        public static void BankSimulator()
        {
            Bank bank = new Bank();
            string input;
            do
            {
                Console.WriteLine("[I]nsättning\n" +
                    "[U]ttag\n" +
                    "[S]aldo\n" +
                    "[A]vsluta");
                Console.Write(":");
                input = Console.ReadLine();
                switch (input)
                {
                    case "I":
                        Console.Write("Belopp:");
                        bank.Deposit(float.Parse(Console.ReadLine()));
                        break;
                    case "U":
                        Console.Write("Belopp:");
                        bank.Withdrawal(float.Parse(Console.ReadLine()));
                        break;
                    case "S":
                        Console.WriteLine($"Saldot är {bank.Balance}kr.");
                            break;
                    case "A":
                        break;
                    default:
                        Console.WriteLine("Felaktigt val, försök igen.");
                        break;
                }
            } while (input != "A");
        }
        //Metod som löser övning 7.5.1 & 7.5.2
        public static void WriteNumbers(int number)
        {
            for (int i = 1; i <= number; i++)            
            {
                Console.WriteLine(i);
            }
        }
        //Metod som löser övning 7.5.3
        public static void HeadOrTails()
        {
            int numberOfTimes;
            Random rnd = new Random();
            string[] headTails = { "krona", "klave" };
            Console.WriteLine("Hur många gånger vill du singla slant?");
            Console.Write(":");

            numberOfTimes = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.WriteLine($"{i+1}: {headTails[rnd.Next(0, 2)]}");
            }
        }
        //Metod som löser övning 7.5.5
        public static void Yatzy()
        {
            Random rnd = new Random();
            Console.WriteLine("Vi kommer nu att spela Yatzy. Vi slår sex tärningar. Resultatet följer nedan.");
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine($"{i}: {rnd.Next(1,7)}");
            }
        }
        
    }
}
