using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class Winner : Hero
    {
        public (string,int,int,int) WhoIsWinner(Hero h1,Hero h2)
        {
            if (h1.HP == 0)
                return (h2.Name,h2.HP, h2.Attack, h2.Defence);
            else
                return (h1.Name,h1.HP,h1.Attack,h1.Defence);
        }
    }
}
