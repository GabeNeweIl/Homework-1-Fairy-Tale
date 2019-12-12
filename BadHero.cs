using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class BadHero : Hero
    {
        public virtual void Speech()
        {
            Console.WriteLine($"I am {Name} and i will do this order half the price!");
        }
        public virtual void WinningSpeech()
        {
            Console.WriteLine("It was easy for me!");
        }
        public virtual void LosingSpeech()
        {
            Console.WriteLine("I can't be...");
        }
    }
}
