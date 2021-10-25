using static lab1.Program;

namespace lab1
{
    class Car : Vehicle
    {
        public string carBrand;
        protected static int numOfWheels;

        static Car()
        {
            numOfWheels = 4;
        }

        public Car()
        {
            carBrand = "Lexus";
        }

        public Car(string carBrand)
        {
            this.carBrand = carBrand;
        }

        public virtual void BeepBeep()
        {
            System.Console.WriteLine("beep beep!!!!");
        }

        public override void Go()
        {
            throw new System.NotImplementedException();
        }

        public override void Stop()
        {
            throw new System.NotImplementedException();
        }
    }


}
