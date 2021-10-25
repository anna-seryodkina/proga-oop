using System;

namespace lab1
{
    public class Fueller
    {
        public event FuellingHandle FuellerFuellingEvent;
        public string name;
        public FuelEventArgs args;

        public Fueller(string name)
        {
            this.name = name;
        }

        public FuelEventArgs SetArgs(int fuel_capacity, string engine_type)
        {
            args = new FuelEventArgs(fuel_capacity, engine_type);
            return args;
        }

        public void Fuelling()
        {
            Console.WriteLine("Fueller {0} is fuelling truck...\n", this.name);

            if (FuellerFuellingEvent != null)
                FuellerFuellingEvent((Fueller)this, args);
        }
    }


}