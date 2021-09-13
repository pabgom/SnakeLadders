using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLaddersLibrary
{
    class RollingDices
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
