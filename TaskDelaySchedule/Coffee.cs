using System;
using System.Collections.Generic;
using System.Text;

namespace TaskDelaySchedule
{
    internal class Coffee
    {
        internal static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}
