using System;

namespace lab1
{
    class LineNotExistException : Exception
    {
        public string Line { get; }

        public LineNotExistException(){}

        public LineNotExistException(string message) : base(message){}

        public LineNotExistException(string message, Exception innerException) : base(message, innerException){}

        public LineNotExistException(string message, string st) : this(message)
        {
            Line = st;
        }
    }

    class Program
    {

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
