using System;

class Program
{
    static void Main()
    {
        // Create two players
        Player player1 = new Player("Player 1");
        Player player2 = new Player("Player 2");

        // Play the game until one player wins
        while (!player1.HasWon() && !player2.HasWon())
        {
            Console.WriteLine($"----- {player1.Name}'s Turn -----");
            player1.PlayTurn();

            if (player1.HasWon())
            {
                Console.WriteLine($"{player1.Name} wins!");
                break;
            }

            Console.WriteLine($"----- {player2.Name}'s Turn -----");
            player2.PlayTurn();

            if (player2.HasWon())
            {
                Console.WriteLine($"{player2.Name} wins!");
                break;
            }
        }
    }
}

class Player
{
    public string Name { get; }
    private int position;

    public Player(string name)
    {
        Name = name;
        position = 0;
    }

    public void PlayTurn()
    {
        // Roll a die (assuming a 6-sided die)
        int roll = new Random().Next(1, 7);

        Console.WriteLine($"{Name} rolled a {roll}");

        // Check if the roll results in a ladder
        if (position + roll <= 100)
        {
            position += roll;

            if (position == 100)
                Console.WriteLine($"{Name} reached the top and won!");
            else
                Console.WriteLine($"{Name} climbed to position {position}, play again!");
        }
        else
        {
            Console.WriteLine($"{Name} stays at position {position}");
        }
    }

    public bool HasWon()
    {
        return position == 100;
    }
}