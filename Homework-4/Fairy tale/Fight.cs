using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class Fight
    {
        List<Hero> heroes = new List<Hero>();
        Winner winner = new Winner();
        public void Fights(Hero h1,Hero h2)
        {
            while (h1.HP != 0 && h2.HP != 0)
            {
                int turn = Randomizer.RandomNumber(0, 2);
                if (turn == 1)
                {
                    Console.WriteLine("This is Lukes move!");
                    Console.WriteLine("Lukes is hitting");
                    (h2.HP, h2.Defence) = h1.Hit(h2.HP, h1.Attack, h2.Defence);
                    h2.GetHP(h2.Name, h2.HP);
                }
                else
                {
                    Console.WriteLine("This is Dart Vader move");
                    Console.WriteLine("Dart Vader is hitting");
                    (h1.HP, h1.Defence) = h2.Hit(h1.HP, h2.Attack, h1.Defence);
                    h1.GetHP(h1.Name, h1.HP);
                }
                if (h1.HP == 0)
                {
                    Console.WriteLine("Dart Vader is winner!");
                    Console.Write("Dart Vader: ");
                    h2.WinningSpeech();
                    Console.Write("Luke: ");
                    h1.LosingSpeech();
                }
                else if (h2.HP == 0)
                {
                    Console.WriteLine("Luke is winner!");
                    Console.Write("Luke: ");
                    h1.WinningSpeech();
                    Console.Write("Dart Vader: ");
                    h2.LosingSpeech();
                }
                Skip.Next();
            }
        }
        public void BossFights(Winner winner,Boss boss)
        {
            while (winner.HP != 0 && boss.HP != 0)
            {
                int turn = Randomizer.RandomNumber(0, 2);
                if (turn == 1)
                {
                    Console.WriteLine($"This is {winner.Name} move!");
                    Console.WriteLine($"{winner.Name} is hitting");
                    (boss.HP, boss.Defence) = winner.Hit(boss.HP, winner.Attack, boss.Defence);
                    boss.GetHP(boss.Name, boss.HP);
                }
                else
                {
                    Console.WriteLine("This is The Boss move");
                    Console.WriteLine("The Boss is hitting");
                    (winner.HP, winner.Defence) = boss.Hit(winner.HP, boss.Attack, winner.Defence);
                    winner.GetHP(winner.Name, winner.HP);
                }
                if (winner.HP == 0)
                {
                    Console.WriteLine("The Boss is winner!");
                    Console.Write("The Boss: ");
                    boss.WinningSpeech();
                    Console.Write($"{winner.Name}: ");
                    winner.LosingSpeech();
                }
                else if (boss.HP == 0)
                {
                    Console.WriteLine($"{winner.Name} is winner!");
                    Console.Write($"{winner.Name}: ");
                    winner.WinningSpeech();
                    Console.Write("The Boss: ");
                    boss.LosingSpeech();
                }
                Skip.Next();
            }
        }
    }
}
