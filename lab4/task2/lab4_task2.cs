using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFoodFactory factory = new CatFoodFactory();
            factory.CreateCheapFood();
            factory.CreateVipLuxuryFood();
        
            factory = new DogFoodFactory();
            factory.CreateCheapFood();
            factory.CreateVipLuxuryFood();

            factory = new BirdFoodFactory();
            factory.CreateCheapFood();
            factory.CreateVipLuxuryFood();
        
            Console.ReadKey();
        }

        abstract class AnimalFoodFactory
        {
            public abstract CheapFood CreateCheapFood();
            public abstract LuxuryFood CreateVipLuxuryFood();
        }

        class CatFoodFactory : AnimalFoodFactory
        {
            public override CheapFood CreateCheapFood()
            {
                CheapFood food = new CatCheapFood();
                Console.WriteLine(food.message + " | price: " + food.price + "$");
                return food;
            }

            public override LuxuryFood CreateVipLuxuryFood()
            {
                LuxuryFood food = new CatLuxuryFood();
                Console.WriteLine(food.message + " | price: " + food.price + "$");
                return food;
            }
        }

        class BirdFoodFactory : AnimalFoodFactory
        {
            public override CheapFood CreateCheapFood()
            {
                CheapFood food = new BirdCheapFood();
                Console.WriteLine(food.message + " | price: " + food.price + "$");
                return food;
            }

            public override LuxuryFood CreateVipLuxuryFood()
            {
                LuxuryFood food = new BirdLuxuryFood();
                Console.WriteLine(food.message + " | price: " + food.price + "$");
                return food;
            }
        }

        class DogFoodFactory : AnimalFoodFactory
        {
            public override CheapFood CreateCheapFood()
            {
                CheapFood food = new DogCheapFood();
                Console.WriteLine(food.message + " | price: " + food.price + "$");
                return food;
            }

            public override LuxuryFood CreateVipLuxuryFood()
            {
                LuxuryFood food = new DogLuxuryFood();
                Console.WriteLine(food.message + " | price: " + food.price + "$");
                return food;
            }
        }


        abstract class CheapFood
        {
            public string message;
            public int price = 10;
        }

        abstract class LuxuryFood
        {
            public string message;
            public int price = 100;
        }

        class CatCheapFood : CheapFood
        {
            public CatCheapFood()
            {
                this.message = "cheap food for CATS";
            }
        }

        class CatLuxuryFood : LuxuryFood
        {
            public CatLuxuryFood()
            {
                this.message = "LuXuRy food for CATS";
            }
        }

        class BirdCheapFood : CheapFood
        {
            public BirdCheapFood()
            {
                this.message = "cheap food for BIRDS";
            }
        }

        class BirdLuxuryFood : LuxuryFood
        {
            public BirdLuxuryFood()
            {
                this.message = "LuXuRy food for BIRDS";
            }
        }

        class DogCheapFood : CheapFood
        {
            public DogCheapFood()
            {
                this.message = "cheap food for DOGS";
            }
        }

        class DogLuxuryFood : LuxuryFood
        {
            public DogLuxuryFood()
            {
                this.message = "LuXuRy food for DOGS";
            }
        }

    }
}
