namespace DiceObject2
{
    public class Dice
    {
        //attributes
        private int _faces;
        //methods
        public int Result { get; protected set; }

        public Random Rnd { get; private set; }
        //custom property

        public int Faces
        {
            get { return _faces; }
            private set {
                if (value >= 1)
                {
                    _faces = value;
                }
                else
                {
                    _faces = 6;
                }
            }
        }

        //Constructor
        public Dice() 
        { 
            Faces = 6;
            Result = 0;
            Rnd = new Random();
        }


        public Dice(int f)
        {
            Faces = f;
            Result = 0;
            Rnd = new Random();
        }

        public void Throw()
        {
            Result = Rnd.Next(1, Faces+1);
        }

        public override string ToString()
        {
            return $"Dice: d{Faces},  result: {Result}";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Example dicethrow a)
            //Create an array to store 5 times throws result
            Dice dice3 = new Dice();
            int[] series = new int[5];

            //make 5 throws in a loop and save result after each throw into the array
            for (int i = 0; i < series.Length; i++) {
                dice3.Throw();
                series[i] = dice3.Result;
            }

            //print dice throw result
            foreach (int result in series) { 
                Console.WriteLine(result);
            }


            //Create an array of 5 dice and a temporary dice pointer var PARTB
            Dice[] seriesb = new Dice[5];
            Dice diceb;

            //create 5 different dice instances and store their pointer to an array
            for (int i = 0; i < seriesb.Length; i++) {
                diceb = new Dice(8);
                diceb.Throw();
                seriesb[i] = diceb;
            }

            foreach (Dice d in seriesb) {
                Console.WriteLine(d.ToString());
            }


            // Example DiceObject 2
            /*
            //Create a default dice (6 sided)
            Dice dice1 = new Dice();
            Console.WriteLine(dice1.Faces);
            Console.WriteLine(dice1.Result);
            //Throw dice1
            dice1.Throw();
            Console.WriteLine(dice1.ToString());
            //Print full string represent of dice1

            Dice dice2 = new Dice(20);
            dice2.Throw();
            Console.WriteLine(dice2.ToString());
            */
        }
    }
}
