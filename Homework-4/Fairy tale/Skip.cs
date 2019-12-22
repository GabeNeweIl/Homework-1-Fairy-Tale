using System;
using System.Collections.Generic;
using System.Text;

namespace Fairy_tale
{
    class Skip
    {
        public static void Next()
        {
            Console.WriteLine("Press an 'Enter' to continue...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
    }
}
