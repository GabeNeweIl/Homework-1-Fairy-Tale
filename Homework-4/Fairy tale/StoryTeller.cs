using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class StoryTeller
    {
        public void FirstAct()
        {
                Console.WriteLine("Hello listener! Let me tell you a story, a story about two fighters.");
                Skip.Next();
                Console.WriteLine("This story isn't ordinary, every time it has an unexpected ending. So listen...");
                Skip.Next();
                Console.WriteLine("Once upon a time, two fighters clashed. The first was jedi from Rebel Alliance");
                Skip.Next();
                Console.WriteLine("Jedi says: ");
        }
        public void SecondAct()
        {
            Console.WriteLine("The second was sith from Impire");
            Console.WriteLine("Witch answered to jedi:");
        }
        public void ThirdAct(Hero hero)
        {
            Console.WriteLine($"After victory {hero.Name} heard someone aprroaching somenow. It was The Boss");
            Console.WriteLine($"Some legends say that after the victory of one of the side, he appears to restore the justice");
            Skip.Next();
            Console.WriteLine($"And now your choice will decide fate of {hero.Name}");
            Console.WriteLine("Choose one: 1 - try to escape; 2 - try to kill The Boss;");

        }
    }
}
