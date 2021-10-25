namespace lab1
{
    class SuperExclusiveTeslaCar : ElectricCar
    {
        static SuperExclusiveTeslaCar superExclusiveTeslaCar;
        SuperExclusiveTeslaCar() {}

        public static SuperExclusiveTeslaCar GetCar()
        {
            if(superExclusiveTeslaCar == null)
            {
                superExclusiveTeslaCar = new SuperExclusiveTeslaCar();
                superExclusiveTeslaCar.carBrand = "Tesla";
            }
            return superExclusiveTeslaCar;
        }
    }
}