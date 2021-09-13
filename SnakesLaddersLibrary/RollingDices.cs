using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UnitTests")]
namespace SnakesLaddersLibrary
{
    internal class RollingDices
    {
        private Random _rnd;
        public RollingDices()
        {
            _rnd = new Random();
        }

        public int Roll()
        {
            return _rnd.Next(1, 6);
        }
    }
}
