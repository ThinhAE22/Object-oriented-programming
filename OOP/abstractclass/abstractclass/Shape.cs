namespace abstractclass
{
    public abstract class Shape
    {
        // properties
        //auto implement x,y
        public int X { get; set; }
        public int Y { get; set; }

        //constructor
        public Shape(int x, int y) {
            X = x;
            Y = y;
        }

        //abstract method
        public abstract double calculatedArea();

        public override string ToString() {
            return $"({X}, {Y})";
        }
    }
}
