using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    abstract class Hero
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int HP { get; set; } = 100;
        public int Damage { get; set; } = 0;
        public void Speech()
        {
            Console.WriteLine($"I am {Name}!");
        }
        public void WinningSpeech()
        {
            Console.WriteLine("I am win!");
        }
        public void LosingSpeech()
        {
            Console.WriteLine("I lost this fight");
        }
        public (int, int) Hit(int hp, int attack, int defence)
        {
            int damage = attack - defence;
            Damage += damage;
            defence -= attack;
            if (defence < 0)
                defence = 0;
            if (damage > 0)
            {
                hp -= damage;
                Console.WriteLine($"{damage} damage done!");
            }
            else Console.WriteLine("No damage done, was a block!");
            if (hp < 0)
                hp = 0;
            return (hp, defence);
        }
        public void GetHP(string name, int hp)
        {
            Console.WriteLine($"{name} have {hp} HP");
        }
        public void GetInfo(int hp, int attack, int defence)
        {
            HP = hp;
            Attack = attack;
            Defence = defence;
            Console.WriteLine($"My parametrs is: HP {HP} , Attack {Attack} and Defence {Defence}.");
        }
        public static int operator +(Hero h1, Hero h2)
        {
            return h1.Damage + h2.Damage;
        }
    }
}
