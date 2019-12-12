using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class GoodHero : Hero
    {
        public virtual void Speech()
        {
            Console.WriteLine($"I am {Name} and i will do this order!");
        }
        public virtual void WinningSpeech()
        {
            Console.WriteLine("Justice restored!");
        }
        public virtual void LosingSpeech()
        {
            Console.WriteLine("Nooooo...");
        }
    }
}
