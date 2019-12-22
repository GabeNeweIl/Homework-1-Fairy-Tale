using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class Randomizer
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            {
                return random.Next(min, max);
            }
        }
    }
}
