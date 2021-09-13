using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UnitTests")]
namespace SnakesLaddersLibrary
{
    internal class Validations
    {
        public static bool OverMaximumSquares(int maximumSquare, int square)
        {
            if(maximumSquare < square)
            {
                Console.WriteLine($" Your last dice move over the maximum Square {maximumSquare}");
                return false;
            }
            return true;
        }
    }
}
