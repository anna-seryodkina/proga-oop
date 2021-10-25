using System;

namespace lab1
{
    class Program
    {

        static void Main(string[] args)
        {
            Fueller fueller = new Fueller("Mike");
            GasStation gasStation = new GasStation(fueller);
            fueller.Fuelling();







            // Console.WriteLine("> [super exclusive tesla car] - { 3 bitcoins }");
            // bool buy = true;

            // if(buy)
            // {
            //     SuperExclusiveTeslaCar car = SuperExclusiveTeslaCar.GetCar();
            //     car.BeepBeep();
            // }


            // int i = 0;

            // while(i < 10000)
            // {
            //     Truck truck = new Truck();
            //     Console.WriteLine($"[{i}] generation: {GC.GetGeneration(truck)}");
            //     truck.Dispose();
            //     GC.ReRegisterForFinalize(truck);
            //     GC.Collect();
            //     GC.WaitForPendingFinalizers();
            //     i++;
            // }

            // Console.WriteLine("total memory: " + GC.GetTotalMemory(true));
        }

    }

}
