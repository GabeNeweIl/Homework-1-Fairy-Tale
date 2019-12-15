using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class Randomizer
    {
        public int Rand(int min, int max)
        {
            Random rand = new Random();
            int value = rand.Next(min, max);
            return value;
        }
    }
}
