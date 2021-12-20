using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskDelaySchedule
{
    internal class Toast
    {
        internal static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }


    }
}
