namespace _07_interface_example
{
    public interface IMovable
    {
        int X { get; set; }
        int Y { get; set; }

        // default realization
        void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        void ResetPosition()
        {
            Move(0, 0);
        }
    }
    public interface IPrintable
    {
        char Filler { get; }
        ConsoleColor Color { get; }
        void Print();
    }

    public interface IShape : IPrintable, IMovable
    {
        string Name { get; }
    }

    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; } // readonly property

        public char Filler { get; init; }
        public ConsoleColor Color { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; } = "Rectangle";

        public void Print()
        {
            Console.ForegroundColor = Color;
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                for (int k = 0; k < Width; k++)
                {
                    Console.Write(Filler);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }

    public class Triangle : IShape
    {
        public int Height { get; set; }
        public char Filler { get; set; }
        public string Name { get; } = "Triangle";
        public ConsoleColor Color { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.ForegroundColor = Color;
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(Filler);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }

    public class Circle : IShape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public char Filler { get; }

        public ConsoleColor Color { get; }

        public string Name { get; }

        public void Print()
        {
            // logic...
        }
    }

    internal class Program
    {
        static void TestShape(IShape shape)
        {
            Console.WriteLine($"{shape.Name} filler: {shape.Filler}");

            //shape.ResetPosition();
            shape.Move(30, 10);
            shape.Print();
        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new()
            {
                Height = 6,
                Width = 20,
                X = 5,
                Y = 5,
                Color = ConsoleColor.DarkRed,
                Filler = '#' // init here
            };
            Triangle triangle = new()
            {
                Height = 12,
                X = 30,
                Y = 10,
                Color = ConsoleColor.Cyan,
                Filler = '*'
            };

            IPrintable printable = new Triangle();

            //printable.Print();

            //rectangle.Filler = 'X'; // error with init-only property

            //((IMovable)triangle).Move(0, 0); // top=-left corner

            //rectangle.Print();
            //triangle.Print();

            TestShape(rectangle);
            TestShape(triangle);
        }
    }
}
