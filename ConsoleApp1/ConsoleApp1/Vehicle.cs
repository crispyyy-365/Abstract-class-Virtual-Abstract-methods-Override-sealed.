using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Vehicle
    {
        public string FactoryName;
        public string Model;
        public string Color;
        public decimal DriveTime;
        public decimal DrivePath;
        public Vehicle(string factoryName, string model, string color, decimal driveTime, decimal drivePath)
        {
            FactoryName = factoryName;
            Model = model;
            Color = color;
            DriveTime = driveTime;
            DrivePath = drivePath;
        }
        public virtual decimal AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"factory name : {FactoryName} , model name : {Model} , color : {Color} , drive time : {DriveTime} , drive path : {DrivePath}");
        }
        public virtual string ToString()
        {
            return FactoryName;
            return Model;
        }
        public abstract void DefineNatureHarmness();
    }
}
