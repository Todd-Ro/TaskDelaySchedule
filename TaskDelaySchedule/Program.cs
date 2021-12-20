using System;
using System.Threading.Tasks;

namespace TaskDelaySchedule
{
    internal class Program
    {
        /*Thanks to Microsoft at 
        https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
        for much of this code*/

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");


        static void Main(string[] args)
        {
            Coffee cup = Coffee.PourCoffee();
            Console.WriteLine("coffee is ready");

            Egg eggs = Egg.FryEggs(2);
            Console.WriteLine("eggs are ready");

            Bacon bacon = Bacon.FryBacon(3);
            Console.WriteLine("bacon is ready");

            Toast toast = Toast.ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = Juice.PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }
    }
}
