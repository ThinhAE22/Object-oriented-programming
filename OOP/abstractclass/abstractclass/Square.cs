namespace abstractclass
{
    public class Square : Shape
    {
        private int _side;
        public int Side
        {
            get { return _side; }
            set
            {
                if (value >= 1)
                {
                    _side = value;
                }
                else
                {
                    _side = 1;
                }
            }
        }

        public Square(int x, int y, int side) : base(x, y)
        {
            Side = side;
        }

        public override double calculatedArea()
        {
            return Side * Side;
        }

        public override string ToString()
        {
            return $"Square at {base.ToString()} with the side of {Side} and surface area of {calculatedArea()}";
        }
    }
}
