// using for JSON serialization
using System.Text.Json.Serialization;

namespace Serialization
{
    public class Dice
    {
        private int _faces;

        public int Faces
        {
            get { return _faces; }
            private set
            {
                if (value >= 1)
                    _faces = value;
                else
                    _faces = 6;
            }
        }

        public int Result { get; protected set; }

        // [JsonIgnore] for leaving out members of a class
        // when serializing
        [JsonIgnore]
        public Random Rnd { get; private set; }

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

        // constructor for serialization
        [JsonConstructor]
        public Dice(int faces, int result)
        {
            Faces = faces;
            Result = result;
            Rnd = new Random();
        }

        public void Throw()
        {
            Result = Rnd.Next(1, Faces + 1);
        }

        public override string ToString()
        {
            return $"Dice: d{Faces}, Result: {Result}";
        }
    }
}
