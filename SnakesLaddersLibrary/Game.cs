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
        private Dictionary<int, int> _dictionarySnakeLadder;

        /// <summary>
        /// If you use this contructor the game will be use default values in maximum Squares and Dictionary Snake Ladder
        /// </summary>
        public Game()
        {
            _maximunSquares = 100;
            _rollDices = new RollingDices();
            LoadDefaultDictionarySnakeLadder();
            _calculateSquare = new CalculateSquare(_dictionarySnakeLadder);
        }

        public Game(int maximumSquares, Dictionary<int,int> dictionarySnakeLadder)
        {
            _maximunSquares = maximumSquares;
            _rollDices = new RollingDices();
            _dictionarySnakeLadder = dictionarySnakeLadder;
            _calculateSquare = new CalculateSquare(_dictionarySnakeLadder);
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

            if(!Validations.OverMaximumSquares(_maximunSquares, nextSquare))
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

        private void LoadDefaultDictionarySnakeLadder()
        {
            _dictionarySnakeLadder = new Dictionary<int, int>();

            // Ladders
            _dictionarySnakeLadder.Add(2, 38);
            _dictionarySnakeLadder.Add(7, 14);
            _dictionarySnakeLadder.Add(8, 31);
            _dictionarySnakeLadder.Add(15, 26);
            _dictionarySnakeLadder.Add(21, 42);
            _dictionarySnakeLadder.Add(28, 84);
            _dictionarySnakeLadder.Add(36, 44);
            _dictionarySnakeLadder.Add(51, 67);
            _dictionarySnakeLadder.Add(71, 91);
            _dictionarySnakeLadder.Add(78, 98);
            _dictionarySnakeLadder.Add(87, 94);


            // Snakes
            _dictionarySnakeLadder.Add(16, 6);
            _dictionarySnakeLadder.Add(46, 25);
            _dictionarySnakeLadder.Add(49, 11);
            _dictionarySnakeLadder.Add(62, 19);
            _dictionarySnakeLadder.Add(64, 60);
            _dictionarySnakeLadder.Add(74, 53);
            _dictionarySnakeLadder.Add(89, 68);
            _dictionarySnakeLadder.Add(92, 88);
            _dictionarySnakeLadder.Add(95, 75);
            _dictionarySnakeLadder.Add(99, 80);
        }
    }
}
