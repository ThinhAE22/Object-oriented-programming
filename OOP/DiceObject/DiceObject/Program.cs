namespace DiceObject
{   
    public class Dice
    {
        //attribute
        private int faces;
        private int result;
        private Random rnd;
        //constructor
        public Dice()
        {
            faces = 6;
            result = 0;
            rnd = new Random();
        }
        //constructor with param
        public Dice(int faces)
        {   
            if (faces >= 1)
            {
                this.faces = faces;
            } else
            {
                this.faces = 6;
            }
            result = 0;
            rnd = new Random();
        }
        //Setter and getter as necessary
        public int GetResult()
        {
            return result;
        }

        public int GetFaces()
        {
            return faces;
        }
        //method
        public void Throw()
        {
            result = rnd.Next(1, faces+1);
        }

        //To-string method only for dice class
        public override string ToString()
        {
            return $"Dice: d{faces}, result: {result}";
        }
    }

 

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice1: ");
            Dice dice1 = new Dice();
            Console.WriteLine(dice1);
            dice1.Throw();
            Console.WriteLine(dice1);

            Console.WriteLine("Dice2: ");
            Dice dice2 = new Dice(20);
            Console.WriteLine(dice2);
            dice2.Throw();
            Console.WriteLine(dice2.ToString());
            Console.WriteLine(dice2.GetResult());
        }
    }
}
