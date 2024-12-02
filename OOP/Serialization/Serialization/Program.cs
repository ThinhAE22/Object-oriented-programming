using System.Text.Json;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SerialDiceSet
            // Create and populate a dice aset
            List<Dice> diceSet = new List<Dice>();
            diceSet.Add(new Dice(4));
            diceSet.Add(new Dice(6));
            diceSet.Add(new Dice(8));
            diceSet.Add(new Dice(10));
            diceSet.Add(new Dice(20));
            diceSet.Add(new Dice(100));

            // Throw all dice in the set once
            foreach (Dice d in diceSet)
            {
                d.Throw();
            }

            // a & b)
            // Serialize set to JSON-formatted text into file DiceSet.json
            // a) JSON without indendation
            string jsonString = JsonSerializer.Serialize<List<Dice>>(diceSet);
            Console.WriteLine(jsonString);

            // b) indendent version of JSON
            // JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            // string jsonString = JsonSerializer.Serialize<List<Dice>>(diceSet, options);
            // Console.WriteLine(jsonString);

            File.WriteAllText("DiceSet.json", jsonString);

            // c)
            // Deserialize set from JSON-formatted text file DiceSet.json into List
            string jsonString2 = File.ReadAllText("DiceSet.json");
            // Console.WriteLine(jsonString2);

            List<Dice> diceSet2 = JsonSerializer.Deserialize<List<Dice>>(jsonString2);

            // Print the list using foreach
            foreach (Dice d in diceSet2)
            {
                Console.WriteLine(d);
            }

            // SerialDice
            /*
            Console.WriteLine("*** a ***");
            Dice dice1 = new Dice(10);
            dice1.Throw();
            Console.WriteLine(dice1);

            string jsonString = JsonSerializer.Serialize<Dice>(dice1);

            Console.WriteLine(jsonString);

            Console.WriteLine("*** b ***");
            File.WriteAllText("Dice.json", jsonString);

            string jsonString2 = File.ReadAllText("Dice.json");
            Console.WriteLine(jsonString2);

            Dice dice2 =
                JsonSerializer.Deserialize<Dice>(jsonString2);

            Console.WriteLine(dice2);
            */
        }
    }
}
