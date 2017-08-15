using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersises
{
    static class ChapterEleven
    {
        //Övning 11.1
        static void Hello(string str)
        {
            Console.WriteLine($"Hello... {str}");
        }
        //Metod för att testa Hello metoden 
        public static void TestHello()
        {
            Console.WriteLine("Metoden hello testas... ");
            Console.Write("Mata in något:");
            Hello(Console.ReadLine());
        }
        //Övning 11.2
        static string ConcatString(string first, string second)
        {
            return first + second;
        }
        //Metod för att testa ConcatString metoden
        public static void TestConcatString()
        {
            string first, second;
            Console.WriteLine("Mata in två textsträngar som ska slås ihop.");
            Console.Write(":");
            first = Console.ReadLine();
            Console.Write(":");
            second = Console.ReadLine();
            Console.WriteLine(ConcatString(first, second)); 
        }
        //Övning 11.3
        static int Add(int first, int second)
        {
            return first + second;
        }
        //Metod för att testa Add metoden
        public static void TestAdd()
        {
            int firstValue, secondValue;
            Console.WriteLine("Mata in två heltal");
            Console.Write(":");
            firstValue = Convert.ToInt32(Console.ReadLine());
            Console.Write(":");
            secondValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{firstValue} + {secondValue} = {Add(firstValue, secondValue)}");
        }
        //Övning 11.4
        static float Vat(float amount)
        {
            amount *= 1.25f;
            return amount;
        }
        //Övning 11.5 (Jag har valt att göra en överlagrning till metoden Vat för denna övning)
        static float Vat(float amount, float vat)
        {
            amount *= vat;
            return amount;
        }
        //Metoder för att testa Vat metoderna.
        public static void TestVat25()
        {
            float amount;
            Console.WriteLine("Ange belopp innan exkl");
            Console.Write(":");
            amount = float.Parse(Console.ReadLine());
            Console.WriteLine($"Exkl moms {amount}kr. Inkl moms {Vat(amount)}kr.");
        }
        public static void TestCustomVat()
        {
            float amount;
            string tmp;
            float vat;
            Console.WriteLine("Ange moms i procent");
            Console.Write(":");
            tmp = "1,"+ Console.ReadLine();
            vat = float.Parse(tmp);
            Console.WriteLine("Ange belopp innan exkl");
            Console.Write(":");
            amount = float.Parse(Console.ReadLine());
            Console.WriteLine($"Exkl moms {amount}kr. Inkl moms {Vat(amount, vat)}kr.");
        }
        //Övning 11.6
        static int ToPercentage(float number)
        {
            return Convert.ToInt32(number * 100);
        }
        //Metod för att testa ToPercentage
        public static void TestToPercentage()
        {
            float number;
            Console.WriteLine("Mata in ett decimaltal");
            Console.Write(":");
            number = float.Parse(Console.ReadLine());
            Console.WriteLine($"Det blir {ToPercentage(number)}%");
        }
        //Övning 11.7
        static bool LegalAge(int age)
        {
            bool legal = false;
            if (age >= 18)
            {
                legal = true;
            }
            return legal;
        }
        //Metod för att testa LegalAge metoden
        public static void TestLegalAge()
        {
            Console.WriteLine("Mata in din ålder");
            Console.Write(":");
            if (LegalAge(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("Du är myndig");
            }
            else
            {
                Console.WriteLine("Du är fortfarande ett barn");
            }
        }
        //Metod för att testa och lösa övning 11.9
        public static void TestMyTemperature()
        {
            string input;
            Console.WriteLine("Mata in [c] för celcius eller [f] för fahrenheit");
            Console.Write(":");
            input = Console.ReadLine();
            switch (input)
            {
                case "c":
                    Console.Write("Mata in ett heltal: ");
                    int celcius = Convert.ToInt32(Console.ReadLine());
                    int fahrenheit = MyTemperature.CelsiusToFahrenheit(celcius);
                    Console.WriteLine($"{celcius} celcius = {fahrenheit} fahrenheit");
                    break;
                case "f":
                    Console.Write("Mata in ett decimaltal: ");
                    float fahrenheit2 = float.Parse(Console.ReadLine());
                    float celcius2 = MyTemperature.FahrenheitToCelcius(fahrenheit2);
                    Console.WriteLine($"{fahrenheit2} fahrenheit = {celcius2} celcius");
                    break;
                default:
                    Console.WriteLine("Felaktigt val");
                    break;
            }
        }
    }
}
