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
    class Bank
    {
        float balance;
        //Property till variablen balance (som håller information om saldot på kontot).
        //Tanken med den är att se till så att värdet på kontot bara kan ändras privat inom klassen.

        public float Balance
        {
            get { return balance; }
            private set { balance = value; }
        }
        //Konstruktor till Bank klassen. Sätter saldot till 0.
        public Bank()
        {
            Balance = 0;
        }

        //Metod för att ta ut pengar.
        public void Withdrawal(float amount)
        {
            if(  Balance - amount > 0)
            {
                Balance = Balance - amount;
                Console.WriteLine($"Du har tagit ut {amount}kr. Dítt saldo är nu {Balance}kr. ");
            }
            else
            {
                Console.WriteLine("Uttag nekas. Det saknas täckning på kontot.");
            }
        }
        //Metod för att sätta in pengar
        public void Deposit(float amount)
        {
            Balance += amount;
            Console.WriteLine($"Du har satt in {amount}kr. Ditt saldo är nu {Balance}kr.");
        }
    }
}
