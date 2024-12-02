namespace DiceMethod
{
    internal class Program
    {
        static int[] ThrowSeries(int throws, int faces)
        {
            int[] distribution = new int[faces]; // an array has faces number element
            int result = 0;
            for (int j = 0; j < throws; j++)
            {
                result = ThrowDice(faces);
                distribution[result - 1] = distribution[result - 1] + 1;
            }

            return distribution;

        }

        static int ThrowDice(int faces)
        {
            Random rnd = new Random();
            int result = rnd.Next(1, faces + 1);
            return result;
        }

        static void PrintDistribution(int[] dist)
        {
            for (int k = 0; k < dist.Length; k++)
            {
                Console.WriteLine($"{k + 1}: {dist[k]}");
            }
        }


        static void Main(string[] args)
        {
            //find highest lowest of each series
            // variables
            
            int throws = 0, faces = 0;

            //array keeping records of dice throw result per series (dice face)
            int[] distribution;

            // outer loop: parsing the dice
            // update the distribution result
            for (int i = 0; i < args.Length; i++)
            {
                //parse round # throws and # faces
                string[] tmp = args[i].Split('d');
                throws = int.Parse(tmp[0]);
                faces = int.Parse(tmp[1]);

                //python has f"" string
                //C# has $
                distribution = new int[faces];
                Console.WriteLine($"Series: {args[i]} ");

                //call throw series method
                //return distribution

                distribution = ThrowSeries(throws, faces);



                //call print the distribution method
                PrintDistribution(distribution);
            }
        }
    }
}
