using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            Year = 2010;
            Make = "Hyundai";
            Model = "Elantra";
            EngineNoise = "Quiet";
            IsDrivable = true;
        }

        public Car(int year, string make, string model, string noise, bool driveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = noise;
            IsDrivable = driveable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise()
        {
            if (this.EngineNoise == "Loud")
            {
                Console.WriteLine("VROOM VROOM!");
            }
            else
            {
                Console.WriteLine("vroom vroom..");
            }
        }

        public void MakeHonkNoise()
        {
            if (this.EngineNoise == "Loud")
            {
                Console.WriteLine("HOOONK HOOONK!");
            }
            else
            {
                Console.WriteLine("beep beep..");
            }
        }

    }
}
