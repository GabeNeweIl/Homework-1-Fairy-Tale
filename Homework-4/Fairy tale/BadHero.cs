using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class BadHero : Hero, HeroSpeech
    {
        public int Speak { get; set; }
        List<string> list = new List<string>();
        List<string> winlist = new List<string>();
        List<string> loselist = new List<string>();
        private void SpeechList()
        {
            list.Add("I will crush the world");
            list.Add("I came to make the world swallow darkness");
            list.Add("I kill you!");
            list.Add("You can not stop me");
            list.Add("You never beat me");
        }
        private void SpeechListWin()
        {
            winlist.Add("Now the world will be crushed!");
            winlist.Add("Now dark will be everywhere");
            winlist.Add("Ahahahaa");
            winlist.Add("It was predictable");
            winlist.Add("I told you");
        }
        private void SpeechListLose()
        {
            list.Add("Nooooo...");
            list.Add("I can not be!");
            list.Add("It is not over yet");
            list.Add("How you do this?");
            list.Add("I will be back");
        }
        
        public virtual void Speech()
        {
            SpeechList();
            int speak = Randomizer.RandomNumber(0,list.Count);
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
        //            Console.WriteLine("I will crush the world");
        //            Speak = chance;
        //            break;
        //        case 2:
        //            Console.WriteLine("I came to make the world swallow darkness");
        //            Speak = chance;
        //            break;
        //        case 3:
        //            Console.WriteLine("I kill you!");
        //            Speak = chance;
        //            break;
        //        case 4:
        //            Console.WriteLine("You can not stop me");
        //            Speak = chance;
        //            break;
        //        case 5:
        //            Console.WriteLine("You never beat me");
        //            Speak = chance;
        //            break;
        //    }
        //}
        //public virtual void WinningSpeech()
        //{
        //    switch (Speak)
        //    {
        //        case 1:
        //            Console.WriteLine("Now the world will be crushed!");
        //            break;
        //        case 2:
        //            Console.WriteLine("Now dark will be everywhere");
        //            break;
        //        case 3:
        //            Console.WriteLine("Ahahahaa");
        //            break;
        //        case 4:
        //            Console.WriteLine("It was predictable");
        //            break;
        //        case 5:
        //            Console.WriteLine("I told you");
        //            break;
        //    }
        //}
        //public virtual void LosingSpeech()
        //{
        //    switch (Speak)
        //    {
        //        case 1:
        //            Console.WriteLine("Nooooo...");
        //            break;
        //        case 2:
        //            Console.WriteLine("I can not be!");
        //            break;
        //        case 3:
        //            Console.WriteLine("It is not over yet");
        //            break;
        //        case 4:
        //            Console.WriteLine("How you do this?");
        //            break;
        //        case 5:
        //            Console.WriteLine("I will be back");
        //            break;
        //    }

        //}
    }
}
