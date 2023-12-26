using System.Text;

namespace _03_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- Arrays --------------");

            string[] colors = ["Red", "Green", "blue", "Purple"];

            Console.WriteLine($"Colors: {colors.Length}"); // 4

            // [0] - first element
            colors[2] = "Black";

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i] + " ");
            }
            Console.WriteLine();

            // TASK: show colors abbreviation (RGB...)
            foreach (string item in colors)
            {
                // item = "New"; - can not change the value
                Console.Write(char.ToUpper(item[0]));
            }
            Console.WriteLine();

            // TODO: investigate StringBuulder
        }
    }
}
