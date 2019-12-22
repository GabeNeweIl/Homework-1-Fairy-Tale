using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class GoodHero : Hero,HeroSpeech
    {
        public int Speak { get; set; }
        List<string> list = new List<string>();
        List<string> winlist = new List<string>();
        List<string> loselist = new List<string>();
        private void SpeechList()
        {
            list.Add("I will restore jistice!");
            list.Add("I came to create world peace");
            list.Add("You shall not pass!");
            list.Add("I will stop you!");
            list.Add("It is not too late to stop...");
        }
        private void SpeechListWin()
        {
            winlist.Add("Justice restored!");
            winlist.Add("Hello world peace...");
            winlist.Add("I told you...");
            winlist.Add("Now you are not threating our world");
            winlist.Add("You had done your choise");
        }
        private void SpeechListLose()
        {
            list.Add("Nooooo...");
            list.Add("Now the world will go dark");
            list.Add("You defeated me");
            list.Add("I could not stop the evil");
            list.Add("I am too weak...");
        }

        public virtual void Speech()
        {
            SpeechList();
            int speak = Randomizer.RandomNumber(0, list.Count);
            Console.WriteLine(list[speak]);
            Speak = speak;
        }
        public virtual void WinningSpeech()
        {
            SpeechListWin();
            Console.WriteLine(winlist[Speak]);
        }
        public virtual void LosingSpeech()
        {
            SpeechListLose();
            Console.WriteLine(loselist[Speak]);
        }
        //public virtual void Speech()
        //{
        //    int chance = Randomizer.RandomNumber(1, 6);
        //    switch (chance)
        //    {
        //        case 1:
        //            Console.WriteLine("I will restore jistice!");
        //            Speak = chance;
        //            break;
        //        case 2:
        //            Console.WriteLine("I came to create world peace");
        //            Speak = chance;
        //            break;
        //        case 3:
        //            Console.WriteLine("You shall not pass!");
        //            Speak = chance;
        //            break;
        //        case 4:
        //            Console.WriteLine("I will stop you!");
        //            Speak = chance;
        //            break;
        //        case 5:
        //            Console.WriteLine("It is not too late to stop...");
        //            Speak = chance;
        //            break;
        //    }
        //}
        //public virtual void WinningSpeech()
        //{
        //        switch (Speak)
        //        {
        //            case 1:
        //                Console.WriteLine("Justice restored!");
        //                break;
        //            case 2:
        //                Console.WriteLine("Hello world peace...");
        //                break;
        //            case 3:
        //                Console.WriteLine("I told you...");
        //                break;
        //            case 4:
        //                Console.WriteLine("Now you are not threating our world");
        //                break;
        //            case 5:
        //                Console.WriteLine("I had done your choise");
        //                break;
        //        }
        //}
        //public virtual void LosingSpeech()
        //{
        //    switch (Speak)
        //    {
        //        case 1:
        //            Console.WriteLine("Nooooo...");
        //            break;
        //        case 2:
        //            Console.WriteLine($"Now the world will go dark");
        //            break;
        //        case 3:
        //            Console.WriteLine($"You defeated me");
        //            break;
        //        case 4:
        //            Console.WriteLine($"I could not stop the evil");
        //            break;
        //        case 5:
        //            Console.WriteLine("I am too weak...");
        //            break;
        //    }

        //}
    }
}
