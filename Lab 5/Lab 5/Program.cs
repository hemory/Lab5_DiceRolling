using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Casino. Roll the Dice y/n?");

            string answer = Console.ReadLine();
            while (answer == "y")
            {
              
                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 6);
                int anotherRandomNumber = rnd.Next(1, 7);
                
                Console.WriteLine(randomNumber);
                Console.WriteLine(anotherRandomNumber);
                

                DiceRollerApp specialRolls = new DiceRollerApp(); //DiceRollerApp is calling the class. specialRolls is 
                //new variable assignment. = new DiceRollerApp(); is new instance.
                
                specialRolls.diceRoll(randomNumber, anotherRandomNumber); //specialRolls is new instance of the class. 
                //(.diceRoll(randomNumber, anotherRandomNumber);) is calling the method
                Console.WriteLine("Roll again? y/n");
                answer = Console.ReadLine(); //this line takes in the user input, without loop will repeat forever.
            }
            
        }
    }
}



