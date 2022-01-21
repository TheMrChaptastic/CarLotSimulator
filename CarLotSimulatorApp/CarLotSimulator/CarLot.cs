using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> CarList = new List<Car>();
       
        public void ShowCars()
        {
            foreach (var c in this.CarList)
            {
                Console.WriteLine($"{c.Year} {c.Make} {c.Model}");
                c.MakeEngineNoise();
                c.MakeHonkNoise();
                Console.WriteLine();
            }
        }
    }
}
