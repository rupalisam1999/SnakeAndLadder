using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0;

            Random random = new Random();

            int noOnDie = random.Next(1, 7);
            Console.WriteLine($"No On Die {noOnDie}");
        }
    }
}
