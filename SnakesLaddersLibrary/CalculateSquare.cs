using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLaddersLibrary
{
    class CalculateSquare
    {
        private Dictionary<int, int> _actions = new Dictionary<int, int>();
        private RollingDices _roll;
        
        internal CalculateSquare()
        { // Ladders
            _actions.Add(2, 38);
            _actions.Add(7, 14);
            _actions.Add(8, 31);
            _actions.Add(15, 26);
            _actions.Add(21, 42);
            _actions.Add(28, 84);
            _actions.Add(36, 44);
            _actions.Add(51, 67);
            _actions.Add(71, 91);
            _actions.Add(78, 98);
            _actions.Add(87, 94);


            // Snakes
            _actions.Add(16, 6);
            _actions.Add(46, 25);
            _actions.Add(49, 11);
            _actions.Add(62, 19);
            _actions.Add(64, 60);
            _actions.Add(74, 53);
            _actions.Add(89, 68);
            _actions.Add(92, 88);
            _actions.Add(95, 75);
            _actions.Add(99, 80);

            _roll = new RollingDices();
        }

        internal int Next(int square, int rollDice)
        {
            int nextSquare = square + rollDice;

            // Check if the next square is a ladder or a snake
            if (_actions.ContainsKey(nextSquare))
            {
                int newSquare = _actions[nextSquare];
             
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
