using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int value=random.Next(1, 7);
            Console.WriteLine($"The Player role the dice and he get number {value}");
        }
    }
}
