using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class GoodHero : Hero,IGoodHeroCpeech
    {
        public int Speak { get; set; }
        public virtual void Speech()
        {
            Random rand = new Random();
            int chance = rand.Next(1, 6);
            switch (chance)
            {
                case 1:
                    Console.WriteLine("I will restore jistice!");
                    Speak = chance;
                    break;
                case 2:
                    Console.WriteLine("I came to create world peace");
                    Speak = chance;
                    break;
                case 3:
                    Console.WriteLine("Yoy shall not pass!");
                    Speak = chance;
                    break;
                case 4:
                    Console.WriteLine("I will stop you!");
                    Speak = chance;
                    break;
                case 5:
                    Console.WriteLine("It is not too late to stop...");
                    Speak = chance;
                    break;
            }
        }
        public virtual void WinningSpeech()
        {
                switch (Speak)
                {
                    case 1:
                        Console.WriteLine("Justice restored!");
                        break;
                    case 2:
                        Console.WriteLine("Hello world peace...");
                        break;
                    case 3:
                        Console.WriteLine("I told you...");
                        break;
                    case 4:
                        Console.WriteLine("Now you are not threating our world");
                        break;
                    case 5:
                        Console.WriteLine("I had done your choise");
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
                    Console.WriteLine($"Now the world will go dark");
                    break;
                case 3:
                    Console.WriteLine($"You defeated me");
                    break;
                case 4:
                    Console.WriteLine($"I could not stop the evil");
                    break;
                case 5:
                    Console.WriteLine("I am too weak...");
                    break;
            }

        }
    }
}
