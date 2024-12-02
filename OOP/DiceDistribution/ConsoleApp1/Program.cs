namespace DiceDistribution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //find highest lowest of each series
            // variables
            Random rnd = new Random();
            int result = 0, throws = 0, faces = 0;

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



                //initialize an array of correct size

                distribution = new int[faces];
                //python has f"" string
                //C# has $
                Console.WriteLine($"Series: {args[i]} ");

                //inner loop
                // do individual throws and print result
                for (int j = 0; j < throws; j++)
                {
                    result = rnd.Next(1, faces + 1);
                    distribution[result - 1] = distribution[result - 1] + 1;
                }


                //print the distribution list
                for (int k = 0; k < distribution.Length; k++)
                {
                    Console.WriteLine($"{k+1}: {distribution[k]}");
                }


            }
        }
    }
}

