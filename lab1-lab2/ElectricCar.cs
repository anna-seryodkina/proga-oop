using System;

namespace lab1
{
    class ElectricCar : Car, IElectricCar, IWheel
    {
        string maxChargingTime;
        string batteryType;
        int numOfEngines;
        int currentChargeLevel;

        public ElectricCar()
        {
            maxChargingTime = "3 hours";
            batteryType = "lithium ion";
            numOfEngines = 1;
            currentChargeLevel = 100;
        }

        public ElectricCar (string maxChargingTime, string batteryType, int numOfEngines, int currentChargeLevel)
        {
            this.maxChargingTime = maxChargingTime;
            this.batteryType = batteryType;
            this.numOfEngines = numOfEngines;
            this.currentChargeLevel = currentChargeLevel;
        }

        public override void BeepBeep()
        {
            System.Console.WriteLine("electro beep over beep!!!");
        }

        private void UpdateChargeLevel()
        {
            // update it somehow
        }

        public void ShowChargeLevel()
        {
            UpdateChargeLevel();

            if(currentChargeLevel <= 25)
            {
                System.Console.WriteLine($"charge level is low :((");

            }

            System.Console.WriteLine($"[{currentChargeLevel}%]");
        }

        public void Charge()
        {
            UpdateChargeLevel();

            if(currentChargeLevel == 100)
            {
                Console.WriteLine("I'm charged.");
                return;
            }

            Console.WriteLine("charging.....");
        }

        void IWheel.Check()
        {
            throw new NotImplementedException();
        }

        void IWheel.Fix()
        {
            throw new NotImplementedException();
        }

        void IWheel.Change()
        {
            throw new NotImplementedException();
        }
    }


}
