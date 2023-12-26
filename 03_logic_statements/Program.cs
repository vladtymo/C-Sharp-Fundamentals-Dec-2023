namespace _03_logic_statements
{
    struct Coord
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Coord(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- Logic Statements --------------");

            LogicStatements();
            //LoopStatements();


            // wait any key
            Console.ReadKey();
        }

        static void LogicStatements()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine()!);

            // if else
            if (age >= 18)
                Console.WriteLine("You have the access to the page!");
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You dont have the access to the page!");
                Console.ResetColor();
            }

            Coord start = new(3, 5); // { Y = 0, X = 0 };

            Console.SetCursorPosition(start.X, start.Y);
            Console.WriteLine("@");

            Console.WriteLine("Press arrow to move the hero...");
            ConsoleKey key;

            do
            {
                key = Console.ReadKey().Key;

                // if else if...
                /*if (key == ConsoleKey.LeftArrow)
                {
                    --start.X;
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    ++start.X;
                }
                else if (key == ConsoleKey.UpArrow)
                {
                    --start.Y;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    ++start.Y;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }*/

                // switch(expression) { case 1... case 2...}
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (start.X > 0) // coord validation
                            --start.X;
                        break; // go out the switch block
                    case ConsoleKey.RightArrow: ++start.X; break;
                    case ConsoleKey.UpArrow: --start.Y; break;
                    case ConsoleKey.DownArrow: ++start.Y; break;

                    case ConsoleKey.Spacebar:
                    case ConsoleKey.Enter:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                }

                // TODO: clear hero in previous coords
                Console.SetCursorPosition(start.X, start.Y);
                Console.WriteLine("@");
                Console.ResetColor();

            } while (key != ConsoleKey.Escape);
        }

        static void LoopStatements()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine()!);

            // while
            while (number < 0)
            {
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine()!);
            }

            // do while
            do
            {
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine()!);

            } while (number < 0);

            // for
            for (int i = 0; i < 30; i++)
            {
                if (i % 4 == 0) continue;   // go to the next iteration

                Console.WriteLine($"Iteration [{i}]");

                if (i % 10 == 0) break;     // go out the for loop
            }
        }
    }
}
