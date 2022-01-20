using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var CarLot = new CarLot();
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            //Done!

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var myCar = new Car();
            CarLot.CarList.Add(myCar);
            var theirCar = new Car() { Year = 1997, Make = "Ford", Model = "F-150", EngineNoise = "Loud", IsDrivable = false };
            CarLot.CarList.Add(theirCar);
            var newCar = new Car(2010, "Nissan", "Santra", "Quiet", true);
            CarLot.CarList.Add(newCar);

            myCar.MakeEngineNoise();
            myCar.MakeHonkNoise();
            Console.WriteLine();
            theirCar.MakeEngineNoise();
            theirCar.MakeHonkNoise();
            Console.WriteLine();
            newCar.MakeEngineNoise();
            newCar.MakeHonkNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            Console.WriteLine();
            foreach (var c in CarLot.CarList)
            {
                Console.WriteLine($"{c.Year} {c.Make} {c.Model}");
            }


            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
