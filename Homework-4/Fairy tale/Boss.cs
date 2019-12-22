using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class Boss : Hero, HeroSpeech
    {
        public int Speak { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }

        public void Speech() 
        {
            Console.WriteLine("I am The BOSS, i take your head and smash it like a watermelon");
        }
        public void WinningSpeech() 
        {
            Console.WriteLine("AHAHAHAHHA \n DIE MISERABLE CREATION!!!!");
        }
        public void LosingSpeech() 
        {
            Console.WriteLine("Impossible, some one like you can not kill me! NOOOOOOO");
        }
    }
}
