using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class Story
    {
        private void Next()
        {
            Console.WriteLine("Press an 'Enter' to continue...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
        public void Start()
        {
            GoodHero good = new GoodHero();
            BadHero bad = new BadHero();
            Hero herog = good;
            Hero herob = bad;
            Random random = new Random();
            good.Name = "Luke Skywalker";
            good.Defence = random.Next(10, 50);
            good.Attack = random.Next(15, 60);
            bad.Name = "Dart Vader";
            bad.Attack = random.Next(10, 50);
            bad.Defence = random.Next(15, 60);
            Console.WriteLine("Hello listener! Let me tell you a story, a story about two fighters.");
            Next();
            Console.WriteLine("This story isn't ordinary, every time it has an unexpected ending. So listen...");
            Next();
            Console.WriteLine("Once upon a time, two fighters clashed. The first was jedi from Rebel Alliance");
            Next();
            Console.WriteLine("Jedi says: ");
            herog.Speech();
            good.Speech();
            good.GetInfo(good.HP, good.Attack, good.Defence);
            Next();
            Console.WriteLine("The second was sith from Impire");
            Console.WriteLine("Witch answered to jedi:");
            herob.Speech();
            bad.Speech();
            bad.GetInfo(bad.HP, bad.Attack, bad.Defence);
            Next();
            Console.WriteLine("And a fight is begin");
            while (good.HP != 0 && bad.HP != 0)
            {
                int turn = random.Next(0, 2);
                if (turn == 1)
                {
                    Console.WriteLine("This is Lukes move!");
                    Console.WriteLine("Lukes is hitting");
                    (bad.HP, bad.Defence) = good.Hit(bad.HP, good.Attack, bad.Defence);
                    bad.GetHP(bad.Name, bad.HP);
                }
                else
                {
                    Console.WriteLine("This is Dart Vader move");
                    Console.WriteLine("Dart Vader is hitting");
                    (good.HP, good.Defence) = bad.Hit(good.HP, bad.Attack, good.Defence);
                    good.GetHP(good.Name, good.HP);
                }
                if (good.HP == 0)
                {
                    Console.WriteLine("Dart Vader is winner!");
                    Console.Write("Dart Vader: ");
                    bad.WinningSpeech();
                    Console.Write("Luke: ");
                    good.LosingSpeech();
                }
                else if (bad.HP == 0)
                {
                    Console.WriteLine("Luke is winner!");
                    Console.Write("Luke: ");
                    good.WinningSpeech();
                    Console.Write("Dart Vader: ");
                    bad.LosingSpeech();
                }
                Next();
            }
            Console.WriteLine("The End...");
            try
            {
                Console.WriteLine("Results of the fight: ");
                Console.WriteLine(good + bad);
                int result = good + bad;
                if (result == 100)
                    throw new Exception("It seems a victory without a cahnce for the enemy");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wow: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
