namespace abstractclass
{
    public class Circle : Shape
    {
        private int _radius;
        public int Radius
        {
            get { return _radius; }
            set
            {
                if (value >= 1)
                {
                    _radius = value;
                }
                else {
                    _radius = 1;
                }
            }
        }

        public Circle (int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public override double calculatedArea()
        {
            return Math.PI*(Radius*Radius);
        }

        public override string ToString()
        {
            return $"Circle at {base.ToString()} with the radius of {Radius} and surface area of {calculatedArea()}";
        }
    }
}
