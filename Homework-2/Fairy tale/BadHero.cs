using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class BadHero : Hero, IBadHeroSpeech
    {
        public int Speak { get; set; }
        public virtual void Speech()
        {
            Random rand = new Random();
            int chance = rand.Next(1, 6);
            switch (chance)
            {
                case 1:
                    Console.WriteLine("I will crush the world");
                    Speak = chance;
                    break;
                case 2:
                    Console.WriteLine("I came to make the world swallow darkness");
                    Speak = chance;
                    break;
                case 3:
                    Console.WriteLine("I kill you!");
                    Speak = chance;
                    break;
                case 4:
                    Console.WriteLine("You can not stop me");
                    Speak = chance;
                    break;
                case 5:
                    Console.WriteLine("You never beat me");
                    Speak = chance;
                    break;
            }
        }
        public virtual void WinningSpeech()
        {
            switch (Speak)
            {
                case 1:
                    Console.WriteLine("Now the world will be crushed!");
                    break;
                case 2:
                    Console.WriteLine("Now dark will be everywhere");
                    break;
                case 3:
                    Console.WriteLine("Ahahahaa");
                    break;
                case 4:
                    Console.WriteLine("It was predictable");
                    break;
                case 5:
                    Console.WriteLine("I told you");
                    break;
            }
        }
        public virtual void LosingSpeech()
        {
            switch (Speak)
            {
                case 1:
                    Console.WriteLine("Nooooo...");
                    break;
                case 2:
                    Console.WriteLine("I can not be!");
                    break;
                case 3:
                    Console.WriteLine("It is not over yet");
                    break;
                case 4:
                    Console.WriteLine("How you do this?");
                    break;
                case 5:
                    Console.WriteLine("I will be back");
                    break;
            }

        }
    }
}
