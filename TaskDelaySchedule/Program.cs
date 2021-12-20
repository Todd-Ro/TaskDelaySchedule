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

        private static void PrepareBreakfastSynchronous()
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

        private static async void PrepareBreakfastAsynchronous()
        {
            Coffee cup = Coffee.PourCoffee();
            Console.WriteLine("coffee is ready");

            Task<Egg> eggsTask = Egg.FryEggsAsync(2);
            
            Task<Bacon> baconTask = Bacon.FryBaconAsync(3);
            
            Task<Toast> toastTask = Toast.ToastBreadAsync(2);

            Toast toast = await toastTask;
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = Juice.PourOJ();
            Console.WriteLine("oj is ready");

            Egg eggs = await eggsTask;
            Console.WriteLine("eggs are ready");
            Bacon bacon = await baconTask;
            Console.WriteLine("bacon is ready");

            Console.WriteLine("Breakfast is ready!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Preparing breakfast in a synchronous (slow) way");
            PrepareBreakfastSynchronous();

            Console.WriteLine("\n \n Now preparing breakfast in an asyncronous (efficient) way");
            PrepareBreakfastAsynchronous();
        }
    }
}
