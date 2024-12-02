namespace LoadedDice
{
    public class Dice
    {
        // attributes == class variables
        private int _faces;

        // manually created Property
        public int Faces
        {
            get { return _faces; }
            private set
            {
                if (value >= 1)
                {
                    _faces = value;
                } else
                {
                    _faces = 6;
                }
            }
        }

        // auto-implemented properties
        public int Result { get; protected set; }
        public Random Rnd { get; private set; }

        // methods

        // constructors
        public Dice()
        {
            Faces = 6;
            Result = 0;
            Rnd = new Random();
        }

        public Dice(int faces)
        {
            Faces = faces;
            Result = 0;
            Rnd = new Random();
        }

        public virtual void Throw()
        {
            Result = Rnd.Next(1, Faces + 1);
        }

        // ToString method for getting the string
        // representation of the class, for example
        // for printing
        public override string ToString()
        {
            return $"Dice: d{Faces}, result: {Result}";
        }
    }
}
