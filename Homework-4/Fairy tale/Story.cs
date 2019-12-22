using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class Story
    {
        public delegate int SomeResult(Hero x,Hero y);
        public delegate void Message(string s);
        public event Message Notify;
        private static void DisplayMessage(string s)
        {
            Console.WriteLine(s);
        }
        public void Start()
        {
            Winner winner = new Winner();
            Fight fight = new Fight();
            StoryTeller story = new StoryTeller();
            GoodHero good = new GoodHero();
            BadHero bad = new BadHero();
            Boss boss = new Boss();
            Hero herog = good;
            Hero herob = bad;
            good.Random(good);
            bad.Random(bad);
            good.Name = "Luke Skywalker";
            bad.Name = "Dart Vader";
            boss.Name = "The Boss";
            boss.Attack = 100;
            boss.Defence = 100;
            boss.HP = 300;
            story.FirstAct();
            herog.Speech();
            good.Speech();
            good.GetInfo(good.HP, good.Attack, good.Defence);
            Skip.Next();
            story.SecondAct();
            herob.Speech();
            bad.Speech();
            bad.GetInfo(bad.HP, bad.Attack, bad.Defence);
            Skip.Next();
            Console.WriteLine("And a fight is begin");
            fight.Fights(good, bad);
            SomeResult someResult = (x, y) => x + y;
            int chance = Randomizer.RandomNumber(1, 10);
            Notify += DisplayMessage;
            try
            {
                int result = someResult(good, bad);              
                if (result == 100)
                {
                    throw new Exception("It seems a victory without a chance for the enemy");
                }
                (winner.Name,winner.HP,winner.Attack,winner.Defence) = winner.WhoIsWinner(good, bad);
                winner.GetInfo(winner.HP,winner.Attack,winner.Defence);
                story.ThirdAct(winner);
                try
                {
                    int act = int.Parse(Console.ReadLine());
                    if (act == 2)
                        fight.BossFights(winner, boss);
                    else if (act == 1)
                        if (chance == 10)
                            Console.WriteLine($"{winner.Name} escaped and stay alive");
                        else
                        {
                            Console.WriteLine($"{winner.Name} could not avoid the fight");
                            fight.BossFights(winner, boss);
                        }
                    else if (act != 1 || act != 2)
                        Console.WriteLine($"Something went wrong and {winner.Name} was killed by a mateorit");
                }
                catch
                {
                    Console.WriteLine($"Something went wrong and {winner.Name} was killed by a mateorit");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wow: {ex.Message}");
                Notify?.Invoke("Impossible it was an exception!");
            }
            Console.WriteLine("The End...");
            Console.ReadKey();
        }
    }
}
