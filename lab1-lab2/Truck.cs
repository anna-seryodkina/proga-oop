using System;

namespace lab1
{

    public delegate void FuellingHandle(Fueller f, FuelEventArgs args);

    class Truck : Vehicle, IDisposable, IWheel
    {
        public int capacity_kg;
        public int fuel_capacity;

        public Truck()
        {
            this.capacity_kg = 2;
            this.fuel_capacity = 10;
        }

        public Truck(int capacity_kg, int fuel_capacity)
        {
            this.capacity_kg = capacity_kg;
            this.fuel_capacity = fuel_capacity;
        }


        public void BeFuelled(Fueller fueller, FuelEventArgs args)
        {
            Console.WriteLine("Truck is fuelling by " + fueller.name);
            Console.WriteLine("Engine:" + args.engine_type + "\nFuel Capacity: " + args.fuel_capacity);
        }


        private bool disposed = false;

        public void Dispose()
        {
            CleanUp(true);
            GC.SuppressFinalize(this);
        }

        private void CleanUp(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    // очищення керованих ресурсів
                    this.capacity_kg = default;
                }
                // очищення некерованих ресурсів
                // їх немає
            }
            disposed = true;
        }

        public override void Go()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }

        public void Check()
        {
            throw new NotImplementedException();
        }

        public void Fix()
        {
            throw new NotImplementedException();
        }

        public void Change()
        {
            throw new NotImplementedException();
        }

        ~Truck()
        {
            CleanUp(false);
            System.Console.WriteLine("destructor...");
        }
    }


}