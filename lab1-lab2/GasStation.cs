using System;

namespace lab1
{
    class GasStation
    {
        public Truck[] trucks;
        public GasStation(Fueller fueller)
        {
            this.trucks = new Truck[]
            {
                new Truck(12, 10),
                new Truck(14, 8),
                new Truck(20, 12)
            };
            foreach(Truck t in trucks)
            {
                fueller.SetArgs(t.fuel_capacity, t.Engine);
                fueller.FuellerFuellingEvent += new FuellingHandle(t.BeFuelled);

                fueller.FuellerFuellingEvent += new FuellingHandle(
                    delegate(Fueller f, FuelEventArgs args)
                    {
                        Console.WriteLine("[Anonymous method tsss.]");
                        Console.WriteLine("Truck is fuelling by " + f.name);
                        Console.WriteLine("Engine:" + args.engine_type + "\nFuel Capacity: " + args.fuel_capacity);
                    }
                );

                fueller.FuellerFuellingEvent += new FuellingHandle(
                    (Fueller f, FuelEventArgs args) => Console.WriteLine("[Lambda.]\nTruck is fuelling by "
                    + f.name + "\nEngine:" + args.engine_type + "\nFuel Capacity: " + args.fuel_capacity)
                );

                fueller.FuellerFuellingEvent += new FuellingHandle(
                    new Action<Fueller, FuelEventArgs>(t.BeFuelled)
                );
            }
        }
    }


}