using System;
using System.Collections.Generic;
using System.Text;

namespace TaskDelaySchedule
{
    internal class Juice
    {
        internal static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }
    }
}
