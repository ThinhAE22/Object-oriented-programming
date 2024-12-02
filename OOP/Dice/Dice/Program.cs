/*
 this is a multiline comment
*/

using System;

namespace Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Variables
            //result of dice throw (1-6)
            int result = 0;
            //number of sixes (0-3)
            int sixes = 0;
            //random number generator 
            Random rnd  = new Random();
            // throw a 6 sided dice 3 times
            //individual ret and update the number of sixes
            for (int i = 0; i < 3; i++) 
            {
                result = rnd.Next(1, 7);
                Console.WriteLine(result);
                if  (result == 6)
                {
                    sixes++;
                }
            }

            //print number of sixes
            if (sixes == 0)
            {
                Console.Write("None");
            } else
            {
                Console.WriteLine(sixes);
            }
        }
    }
}
