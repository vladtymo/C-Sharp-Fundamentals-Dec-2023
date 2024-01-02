using System.Diagnostics;

namespace _05_interfaces
{
    public interface ITest
    {
        public void Move()
        {
            Console.WriteLine("Tets move!");
        }
    }
    public interface IAnimal
    {
        // all interface members public by default

        // C# 8.0 provide: private, protected, static members
        private int BirthYear => DateTime.Now.Year - Age;
        static string type = "Regulal animal";
        
        // ---------- properties
        public string Name { get; init; }
        public int Age { get; set; }

        // ---------- methods
        // default realization (C# 8.0)
        public void Print()
        {
            Console.WriteLine($"I am {Name} and born at {BirthYear}!");
        }
        public void MakeSound();

        // ---------- events
        // ---------- indexers[]
    }

    public interface IMovable
    {
        public int Speed { get; set; }
        public void Move();
        protected void Stop()
        {
            Console.WriteLine("Stoping...");
        }

    }

    public interface ISwimable : IMovable
    {
        public void Test()
        {
            Stop();
        }
        public int SwimDepth { get; set; }
        public void Swim();
    }

    public class Parrot : IAnimal
    {
        public string Name { get; init; }
        public int FlyHeight { get; set; }

        public int Age { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("Hello, I like C#");
        }

        public void Move()
        {
            Console.WriteLine($"Flying on height of {FlyHeight}m...");
        }
    }

    public class Shark : IAnimal, ISwimable, ITest
    {
        public string Name { get; init; }

        public int Age { get; set; }
        public int SwimDepth { get; set; }
        public int Speed { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("Bul-bul-bul...");
        }

        // explicit implementation
        void ITest.Move()
        {
            Console.WriteLine("Custom move!");
        }
        public void Move()
        {
            Console.WriteLine("Shark is swimming...");
        }

        public void Swim()
        {
            Console.WriteLine($"I am swimming up to {SwimDepth}m of depth...");
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"I am {Name} and {Age} years old!");
            Console.ResetColor();
        }
    }

    public class Frog : ISwimable, IAnimal
    {
        public string Name { get; init; }

        public int Age { get; set; }
        public int SwimDepth { get; set; }
        public int Speed { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("Kva-kva-kva...");
        }

        public void Move()
        {
            Console.WriteLine("Frog is jumping...");
        }

        public void Swim()
        {
            Console.WriteLine($"I am swimming up to {SwimDepth}m of depth...");
        }
    }

    internal class Program
    {
        static void ShowAnimal(IAnimal animal)
        {
            animal.Print();
            animal.MakeSound();
            Console.WriteLine("--------------------");
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("---------------- Interfaces ----------------");

            Parrot bird = new()
            {
                Name = "Gosha",
                Age = 2
            };

            bird.Age++;
            // can not change Name
            //bird.Name = "New";

            Shark shark = new() { Name = "Shark", Age = 12 };
            Frog frog = new() { Name = "Frog", Age = 4 };

            ((ITest)shark).Move();

            // intrface reference
            IAnimal animal = frog;

            ShowAnimal(bird);
            ShowAnimal(shark);
            ShowAnimal(frog);
        }
    }
}
