using System;

namespace lab1
{

    static class Program
    {
        static string NewMethod(this SuperExclusiveTeslaCar obj)
        {
            return $"I'm {obj.color} {obj.carBrand}. I'm super cool.";
        }

        static void Main(string[] args)
        {
            Fueller fueller = new Fueller("Mike");
            GasStation gasStation = new GasStation(fueller);
            fueller.Fuelling();



            try
            {
                Subway subway = new Subway();
                subway.CurrentStation = "station1";
            }
            catch (LineNotExistException ex)
            {
                Console.WriteLine(ex.Message + $"[{ex.Line}]");
            }


            try
            {
                try
                {
                    Subway subway = new Subway();
                    subway.CurrentStation = "station1";
                }
                catch(LineNotExistException ex)
                {
                    Console.WriteLine(ex.Message + $"[{ex.Line}]");
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception happened.");
                Console.WriteLine(ex.StackTrace);
            }





            Console.WriteLine("> [super exclusive tesla car] - { 3 bitcoins }");
            bool buy = true;

            if(buy)
            {
                SuperExclusiveTeslaCar car = SuperExclusiveTeslaCar.GetCar();
                car.BeepBeep();
                Func<SuperExclusiveTeslaCar, string> extention = NewMethod;

                Console.WriteLine(extention);
            }


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
