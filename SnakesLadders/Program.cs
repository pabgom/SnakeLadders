using SnakesLaddersLibrary;
using System;

namespace SnakesLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPlayers = 0;            
            
            while (numPlayers == 0)
            {
                Console.WriteLine("Number of Players:");
                var input = Console.ReadLine();
                int.TryParse(input, out numPlayers);
            }

            var game = new Game();
            var players = game.InitPlayers(numPlayers);

            bool stopGame = false;
            while (!stopGame)
            {
                for (int i = 1; i <= players.Length; i++)
                {
                    Console.WriteLine($"Player {i} Turn");
                    //Console.ReadLine();
                    int square = game.NextTurn(i, players[i - 1]);
                    players[i - 1] = square;
                    if (square == 100)
                    {
                        Console.WriteLine($"Player {i} win.");
                        stopGame = true;
                        break;
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
