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
    class Menu
    {
        string mainMenu =
            "[1] Kapitel 7 och 8\n" +
            "[2] Kapitel 11\n" +
            "[3] Om programmet\n" +
            "[Q] Avsluta\n";

        string chapterSevenAndEightMenu =
            "[1] 7.1.2      -Summan av två tal-\n" +
            "[2] 7.1.3      -Summan och medelvärdet av tre tal-\n" +
            "[3] 7.1.4      -Decimaltal till heltal-\n" +
            "[4] 7.1.5      -En saga med två string-variabler-\n" +
            "[5] 7.1.6      -Avrunda flyttal-\n" +
            "[6] 7.1.9      -Felaktiga variabeltyper\n" +
            "[7] 7.3.1->3   -Kontrollera vädret\n" +
            "[8] 7.3.4->5   -Var är det kallast?\n" +
            "[9] 7.3.6      -Felaktig if-sats\n" +
            "[10] 7.4.2     -Banksimulator\n" +
            "[11] 7.5.1     -Skriva ut talföljd (1-20)\n" +
            "[12] 7.5.2     -Skriva ut talföljd (upp till 100)\n" +
            "[13] 7.5.3     -Krona eller klave\n" +
            "[14] 7.5.5     -Yatzy\n" +
            "[15] 8.1       -Termostat\n" +
            "[Q] Avsluta\n";
        string chapterElevenMenu =
            "[1] 11.1       -Hello\n" +
            "[2] 11.2       -Lägga samman två textsträngar\n" +
            "[3] 11.3       -Addera\n" +
            "[4] 11.4       -Ränka ut moms del 1\n" +
            "[5] 11.5       -Ränka ut moms del 2\n" +
            "[6] 11.6       -ToPercentage()\n" +
            "[7] 11.7       -Myndig?\n" +
            "[8] 11.9       -Klassen MyTemperature\n" +
            "[Q] Avsluta\n";


        public void InitMainMenu()
        {
            string input;
            do
            {
                Console.Clear();
                Console.Write(mainMenu);
                Console.Write(":");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        InitChapterSevenAndEightMenu();
                        break;
                    case "2":
                        InitChapterElevenMenu();
                        break;
                    case "3":
                        About();
                        break;
                    case "q":
                        break;
                    case "Q":
                        break;
                    default:
                        DefaultCase();
                        break;
                }
            } while (input != "q" && input != "Q");
        }

        void About()
        {
            Console.WriteLine("Det här programmet är skrivet av Gustav Themer, gustav@themer.se\n" +
                "under sommaren 2017. \nDet innehåller de praktiska övningarna från boken\n" +
                "Programmering med C# 1 Arbetsbok, upp till kapitel 11.");
            Console.ReadLine();
        }

        void InitChapterSevenAndEightMenu()
        {
            string input;
            Console.Clear();
            do
            {
                Console.Write(chapterSevenAndEightMenu);
                Console.Write(": ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //Övning 7.1.2
                        NormalCase(ChapterSeven.SumOfTwo);
                        break;
                    case "2":
                        //Övning 7.1.3
                        NormalCase(ChapterSeven.SumAndAverageOfThree);
                        break;
                    case "3":
                        //Övning 7.1.4
                        NormalCase(ChapterSeven.RoundAndDisplay);
                        break;
                    case "4":
                        //Övning 7.1.5
                        NormalCase(ChapterSeven.ShortStory);
                        break;
                    case "5":
                        //Övning 7.1.6
                        NormalCase(ChapterSeven.RoundToTwo);
                        break;
                    case "6":
                        //Övning 7.1.9
                        NormalCase(ChapterSeven.TwoSolutions);
                        break;
                    case "7":
                        //Övningarna 7.3.1 -> 7.3.3
                        NormalCase(ChapterSeven.CheckWeather);
                        break;
                    case "8":
                        //Övningarna 7.3.4 samt 7.3.5
                        NormalCase(ChapterSeven.WhereIsItTheColdest);
                        break;
                    case "9":
                        //Övning 7.3.6
                        NormalCase(ChapterSeven.CorrectIfStatment);
                        break;
                    case "10":
                        //Övning 7.4.2
                        NormalCase(ChapterSeven.BankSimulator);
                        break;
                    case "11":
                        //Övning 7.5.1
                        Console.Clear();
                        ChapterSeven.WriteNumbers(20);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "12":
                        //Övning 7.5.2
                        Console.Clear();
                        Console.Write("Mata in ett tal: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        if(number > 0 && number <= 100)
                        {
                            ChapterSeven.WriteNumbers(number);
                        }                        
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "13":
                        //Övning 7.5.3
                        NormalCase(ChapterSeven.HeadOrTails);
                        break;
                    case "14":
                        //Övning 7.5.5
                        NormalCase(ChapterSeven.Yatzy);
                        break;
                    case "15":
                        //Övning 8.1
                        NormalCase(ChapterEight.Temperature);
                        break;
                    case "Q":
                        break;
                    case "q":
                        break;
                    default:
                        DefaultCase();
                        break;
                }
            } while (input != "q" && input != "Q");

        }

        void InitChapterElevenMenu()
        {
            string input;
            Console.Clear();
            do
            {
                Console.Write(chapterElevenMenu);
                Console.Write(": ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //Övning 11.1
                        NormalCase(ChapterEleven.TestHello);
                        break;
                    case "2":
                        //Övning 11.2
                        NormalCase(ChapterEleven.TestConcatString);
                        break;
                    case "3":
                        //Övning 11.3
                        NormalCase(ChapterEleven.TestAdd);
                        break;
                    case "4":
                        //Övning 11.4
                        NormalCase(ChapterEleven.TestVat25);
                        break;
                    case "5":
                        //Övning 11.5
                        NormalCase(ChapterEleven.TestCustomVat);
                        break;
                    case "6":
                        //Övning 11.6
                        NormalCase(ChapterEleven.TestToPercentage);
                        break;
                    case "7":
                        //Övning 11.7
                        NormalCase(ChapterEleven.TestLegalAge);
                        break;
                    case "8":
                        //Övning 11.9
                        NormalCase(ChapterEleven.TestMyTemperature);
                        break;
                    case "Q":
                        break;
                    case "q":
                        break;
                    default:
                        DefaultCase();
                        break;
                }
            } while (input != "q" && input != "Q");

        }
        private static void NormalCase(Action method)
        {
            Console.Clear();
            method();
            Console.ReadLine();
            Console.Clear();
        }
        private static void DefaultCase()
        {
            Console.Clear();
            Console.WriteLine("Felaktigt val, försök igen.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
