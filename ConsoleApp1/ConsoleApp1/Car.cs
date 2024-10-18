using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car : Vehicle
    {
        public int DoorCount;
        public bool IsElectricCar;
        public Car(string factoryName, string model, string color, decimal driveTime, decimal drivePath, int doorCount, bool isElectricCar) : base(factoryName, model, color, driveTime, drivePath)
        {
            DoorCount = doorCount;

            if (doorCount < 0)
            {
                DoorCount = 0;
            }
            else
            {
                DoorCount = doorCount;
            }

            IsElectricCar = isElectricCar;
        }
        public override decimal AverageSpeed()
        {
            return base.AverageSpeed();
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"door count : {DoorCount} , is electric car ? : {IsElectricCar}");
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override void DefineNatureHarmness()
        {
            if (IsElectricCar)
            {
                Console.WriteLine("Low");
            }
            else
            {
                Console.WriteLine("High");
            }
        }
    }
}
