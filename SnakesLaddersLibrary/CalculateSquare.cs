using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UnitTests")]
namespace SnakesLaddersLibrary
{
    class CalculateSquare
    {
        private Dictionary<int, int> _dictionarySnakeLadder = new Dictionary<int, int>();
        
        internal CalculateSquare(Dictionary<int,int> dictionarySnakeLadder)
        {
            _dictionarySnakeLadder = dictionarySnakeLadder;
        }

        internal int Next(int square, int rollDice)
        {
            int nextSquare = square + rollDice;

            // Check if the next square is a ladder or a snake
            if (_dictionarySnakeLadder.ContainsKey(nextSquare))
            {
                int newSquare = _dictionarySnakeLadder[nextSquare];
             
               // if the newSquare is greater than and nextSquare is a Ladder
                if(newSquare > nextSquare)
                {
                    Console.WriteLine($" the new square is a ladder. Climb up to {newSquare}");
                }
                // if the newSquare is Lower than and nextSquare is a Snake
                else if (newSquare < nextSquare)
                {
                    Console.WriteLine($" the new square is a snake. Go Down to {newSquare}");
                }

                return newSquare;
            }

            return nextSquare;
        }
    }
}
