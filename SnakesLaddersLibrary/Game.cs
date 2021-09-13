using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLaddersLibrary
{
    public class Game
    {
        private int _maximunSquares;
        private RollingDices _rollDices;
        private CalculateSquare _calculateSquare;

        public Game()
        {
            _maximunSquares = 100;
            _rollDices = new RollingDices();
            _calculateSquare = new CalculateSquare();
        }

        public int[] InitPlayers(int numPlayers)
        {
            var players = new int[numPlayers];

            for (int i = 0; i < numPlayers; i++)
            {
                players[0] = 1;
            }

            return players;
        }

        public int NextTurn(int playerNumber, int square)
        {
            // Roll Dice 
            int rollDice = _rollDices.Roll();

            Console.Write($"Player {playerNumber}, in square {square}, rolls {rollDice}");

            int nextSquare = _calculateSquare.Next(square, rollDice);

            if(Validations.OverMaximumSquares(_maximunSquares, nextSquare))
            {
                return square;
            }

            Console.WriteLine($" moves to square {nextSquare}");
            if(nextSquare == 100)
            {
                return nextSquare;
            }

            return nextSquare;
        }
    }
}
