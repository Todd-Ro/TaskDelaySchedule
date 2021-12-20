using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskDelaySchedule
{
    internal class Egg
    {
        internal static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");

            //return new Egg();
        }

        internal static async Task<Egg> FryEggsAsync(int howMany)
        {
            return FryEggs(howMany);
        }
    }
}
