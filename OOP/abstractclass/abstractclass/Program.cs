namespace abstractclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            //test da code
            shapes.Add(new Square(2,3,4));
            shapes.Add(new Circle(1, 1, 1));
            shapes.Add(new Square(3, 3, 7));
            shapes.Add(new Circle(1, 1, 6));
            shapes.Add(new Square(6, 7, 8));

            foreach (Shape shape in shapes) { 
                Console.WriteLine(shape.ToString());
            }

            /*Circle c1 = new Circle(1,1,1);
            Console.WriteLine(c1.ToString());

            Square s1 = new Square(-2,-1,-2);
            Console.WriteLine(s1.ToString());*/
        }
    }
}
