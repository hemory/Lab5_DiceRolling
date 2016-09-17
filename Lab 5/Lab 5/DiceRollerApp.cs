using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class DiceRollerApp
    {
        public void diceRoll(int d1, int d2) //To make a class you need "public" "void" and then name your variable.
            //Then make a new variables. With "void" you dont need a return. 
        {
            if (d1 == 2 && d2 == 2) //your parameters
            {
                Console.WriteLine("Snake Eyes!"); // code to execute
            }
            else if (d1 == 4 && d2 == 4)
            {
                Console.WriteLine("Box Cars!");
            }
            else if (d1 == 6 && d2 == 6)
            {
                {
                    Console.WriteLine("Craps!");
                }
            }

        }
    }
}
