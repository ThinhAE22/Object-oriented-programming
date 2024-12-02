namespace LoadedDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example DiceThrow2
            //List containing Dice instances
            List<Dice> series = new List<Dice>();
            Dice dice = new Dice();

            //create 5 dice, throw, add to list
            for (int i = 0; i < 5; i++)
            {
                if (i < 3)
                {
                    //Dice instances
                    dice = new Dice(8);
                }
                else
                {
                    //Loaded Dice instances
                    dice = new LoadedDice(20);
                }
                // throw the created dice and add it to the list
                dice.Throw();
                series.Add(dice);
            }

            //Go through da list
            for (int i = 0; i < series.Count; i++) 
            {
                Console.WriteLine(series[i]);
            }
            
            /*
            Dice dice = new Dice();
            dice.Throw();
            Console.WriteLine(dice);

            LoadedDice loadedDice1 = new LoadedDice();
            loadedDice1.Throw();
            Console.WriteLine(loadedDice1);

            LoadedDice loadedDice2 = new LoadedDice(20);
            loadedDice2.Throw();
            Console.WriteLine(loadedDice2);

            LoadedDice loadedDice3 = new LoadedDice(8, 4);
            loadedDice3.Throw();
            Console.WriteLine(loadedDice3);
            */
        }
    }
}
