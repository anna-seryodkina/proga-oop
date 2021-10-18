using System;

namespace lab1
{
    class Truck : Vehicle, IDisposable
    {
        public int capacity_kg;

        public Truck()
        {
            this.capacity_kg = 2;
        }

        public Truck(int capacity_kg)
        {
            this.capacity_kg = capacity_kg;
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

        ~Truck()
        {
            CleanUp(false);
        }
    }


}