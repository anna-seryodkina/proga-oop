namespace lab1
{
    class Vehicle
    {
        int speed_miles;
        public string color;
        string engineType;
        public int numberOfSeats;

        public Vehicle()
        {
            speed_miles = 100;
            color = "black";
            engineType = "diesel";
            numberOfSeats = 2;
        }

        public Vehicle(int speed_miles, string color, string engineType, int numberOfSeats)
        {
            this.speed_miles = speed_miles;
            this.color = color;
            this.engineType = engineType;
            this.numberOfSeats = numberOfSeats;
        }


        public int Speed
        {
            get
            {
                return System.Convert.ToInt32(speed_miles*1.6); // returns speed in km
            }
            set
            {
                if (value > 0) // value is speed in km
                {
                    speed_miles = System.Convert.ToInt32(value/1.6);
                }
            }
        }
    }


}
