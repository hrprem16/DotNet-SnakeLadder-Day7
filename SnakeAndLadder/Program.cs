using System;

class SnakeLadder
{
    class Program
    {
        static void Main()
        {
            // Initialize random number generator
            Random random = new Random();

            // Player's initial position
            int playerPosition = 0;

            // Roll the die using ((RANDOM))
            int dieResult = random.Next(1, 7);

            // Check for options: No Play, Ladder, or Snake
            int option = random.Next(1, 4);

            switch (option)
            {
                case 1:
                    // No Play: Player stays in the same position
                    Console.WriteLine("No Play. Player stays at position " + playerPosition);
                    break;
                case 2:
                    // Ladder: Player moves ahead by the number of positions received in the die
                    playerPosition += dieResult;
                    Console.WriteLine("Ladder! Player moves ahead by " + dieResult + " positions. New position: " + playerPosition);
                    break;
                case 3:
                    // Snake: Player moves behind by the number of positions received in the die
                    playerPosition -= dieResult;
                    Console.WriteLine("Snake! Player moves behind by " + dieResult + " positions. New position: " + playerPosition);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}