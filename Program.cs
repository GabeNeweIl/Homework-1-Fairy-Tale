using System;

namespace Fairy_tale
{
    class Program
    {
        static void Main(string[] args)
        {
            void Next()
            {
                Console.WriteLine("Press an 'Enter' to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }
            Hero hero = new Hero();
            GoodHero UkraininaProgrammer = new GoodHero();
            var rand = new Random();
            UkraininaProgrammer.Name = "Peter";
            UkraininaProgrammer.Defence = rand.Next(15, 90);
            UkraininaProgrammer.Attack = rand.Next(10,100);
            BadHero HinduProgrammer = new BadHero();
            HinduProgrammer.Name = "Akil";
            HinduProgrammer.Attack = rand.Next(10, 100);
            HinduProgrammer.Defence = rand.Next(15, 90);
            Console.WriteLine("Hello listener! Let me tell you a story, a story about two fighters.");
            Next();
            Console.WriteLine("This story isn't ordinary, every time it has an unexpected ending. So listen...");
            Next();
            Console.WriteLine("Once upon a time, two wars clashed. The first was programmer from Ukraine named Peter");
            Next();
            Console.WriteLine($"Peter's says:");
            UkraininaProgrammer.Speech();
            UkraininaProgrammer.GetInfo(UkraininaProgrammer.HP, UkraininaProgrammer.Attack, UkraininaProgrammer.Defence);
            Next();
            Console.WriteLine("The second was programmer from India named Akil");
            Console.WriteLine("To witch Hindu programmer answered him:");
            HinduProgrammer.Speech();
            HinduProgrammer.GetInfo(HinduProgrammer.HP, HinduProgrammer.Attack, HinduProgrammer.Defence);
            Next();
            Console.WriteLine("And a fight is begin");
            while (UkraininaProgrammer.HP != 0 && HinduProgrammer.HP != 0)
            {
                int turn = rand.Next(0, 2);
                if (turn == 1)
                {
                    Console.WriteLine("This is Peters move!");
                    Console.WriteLine("Peter is hitting");
                    (HinduProgrammer.HP, HinduProgrammer.Defence) = UkraininaProgrammer.Hit(HinduProgrammer.HP,UkraininaProgrammer.Attack, HinduProgrammer.Defence);
                    HinduProgrammer.GetHP(HinduProgrammer.Name, HinduProgrammer.HP);
                }
                else
                {
                    Console.WriteLine("This is Akils move");
                    Console.WriteLine("Akil is hitting");
                    (UkraininaProgrammer.HP, UkraininaProgrammer.Defence) = HinduProgrammer.Hit(UkraininaProgrammer.HP,HinduProgrammer.Attack, UkraininaProgrammer.Defence);
                    UkraininaProgrammer.GetHP(UkraininaProgrammer.Name, UkraininaProgrammer.HP);
                }
                if (UkraininaProgrammer.HP == 0)
                {
                    Console.WriteLine("Akil is winner!");
                    Console.Write("Akil: ");
                    HinduProgrammer.WinningSpeech();
                    Console.Write("Peter: ");
                    UkraininaProgrammer.LosingSpeech();
                }
                else if (HinduProgrammer.HP == 0)
                {
                    Console.WriteLine("Peter is winner!");
                    Console.Write("Peter: ");
                    UkraininaProgrammer.WinningSpeech();
                    Console.Write("Akil: ");
                    HinduProgrammer.LosingSpeech();
                }
                Next();
            }
            Console.WriteLine("The End...");
            Console.ReadKey();
        }
    }
}
