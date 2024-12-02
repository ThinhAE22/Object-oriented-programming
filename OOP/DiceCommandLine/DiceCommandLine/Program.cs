namespace DiceCommandLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //find highest lowest of each series
            // variables
            Random rnd = new Random();
            int result = 0, throws = 0, faces = 0,lowest = 0,highest = 0;
            // outer loop: parsing the dice
            // throw series info (# throws and  # faces)
            for (int i = 0; i < args.Length; i++) {
                //parse round # throws and # faces
                string[] tmp = args[i].Split('d');
                throws = int.Parse(tmp[0]);
                faces = int.Parse(tmp[1]);
                //python has f"" string
                //C# has $
                Console.WriteLine($"Series: {args[i]} ");
                
                //inner loop
                // do individual throws and print result
                for (int j = 0; j < throws; j++) { 
                    result= rnd.Next(1, faces +1);
                    Console.WriteLine(result);
                    //find the highest and lowest value
                    if (lowest == 0|| result < lowest)
                    {
                        lowest = result;

                    }
                    if (result > highest) {
                        highest = result;
                    }
                
                }
                //print highest lowest ret of the throw
                Console.WriteLine("Lowest: " + lowest);
                Console.WriteLine("Highest: " + highest);
            }
        }
    }
}
