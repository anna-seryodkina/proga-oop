using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while(i < 10000)
            {
                Truck truck = new Truck();
                Console.WriteLine($"[{i}] generation: {GC.GetGeneration(truck)}");
                truck.Dispose();
                GC.ReRegisterForFinalize(truck);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                i++;
            }

            Console.WriteLine("total memory: " + GC.GetTotalMemory(true));
        }

    }

}
