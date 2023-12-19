using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // inline comment

        /*
            block comment
        */

        // [Alt] + [Up/Down]
        //Console.SetWindowSize(40, 20);
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.White;

        // ------------------ console output
        // [cw] + [Tab] = Console.WriteLine();
        Console.WriteLine("First line in console!");
        Console.ResetColor();

        Console.Write("Hello-");
        Console.Write("C#!");

        // escape sequence: \n \t \' \" \\
        Console.WriteLine("Hello, \"Vlad\"!");
        Console.WriteLine("Red\n\tGreen\n\t\tBlue");
        Console.WriteLine("New\\none!");

        // @ - ignore escape chars
        Console.WriteLine(@"C:\Users\vlad\test.txt");

        // ------------------ variables
        int age = 18; // 4 bytes
        const int maxMark = 12;

        // maxMark = 13; - error, cannot change const

        // string concatenation: str + str
        Console.WriteLine("You are " + age + " years old");

        // string interpolation (C# 6.0): $"...{expression}..."
        Console.WriteLine($"You are {age} years old");

        // ------------------ console input
        Console.Write("Enter your login: ");
        string? login = Console.ReadLine();

        Console.WriteLine($"Hello, dear {login}!");

        // -------------- operators
        // ariphmetic: + - * / %
        Console.WriteLine(2 + 2);       // 4
        Console.WriteLine("2" + "2");   // "22"
        Console.WriteLine(17 % 5);      // 17 / 5 = 2

        // logic: > < >= <= != ==
        // all logic operatros return boolean type (true/false)
        Console.WriteLine(5 > 10);          // false
        Console.WriteLine(4 >= 4);          // true
        Console.WriteLine("Red" == "red");  // false
        Console.WriteLine(45 != 45.5);      // true

        Console.WriteLine("Bob".CompareTo("Julia")); // (-1 0 +1)

        // -------------- parse string to other types
        int num = int.Parse("22");
        float koef = float.Parse("34.5");

        // -------------- Math
        Console.WriteLine(Math.Abs(-10));       // 10
        Console.WriteLine(Math.Pow(2, 8));      // 256
        Console.WriteLine(Math.Round(5.5));     // 6
        Console.WriteLine(Math.Floor(5.9));     // 5
        Console.WriteLine(Math.Ceiling(5.1));   // 6

        // TASK: ask user for circle radius and show the circle area
        Console.Write("Circle radius (cm): ");
        int radius = int.Parse(Console.ReadLine());

        double area = Math.Round(Math.PI * Math.Pow(radius, 2));

        Console.WriteLine($"Radius: {radius}cm");
        Console.WriteLine($"Area: {area}cm^2"); // S = P * R^2
    }
}