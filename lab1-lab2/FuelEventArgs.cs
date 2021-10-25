using System;

namespace lab1
{
    public class FuelEventArgs : EventArgs
    {
        public int fuel_capacity;
        public string engine_type;

        public FuelEventArgs(int fuel_capacity, string engine_type)
        {
            this.fuel_capacity = fuel_capacity;
            this.engine_type = engine_type;
        }

        public FuelEventArgs() : this(0, "") { }
    }


}