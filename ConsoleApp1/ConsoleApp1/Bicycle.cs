using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bicycle : Vehicle
    {
        public string Type;

        public Bicycle(string factoryName, string model, string color, decimal driveTime, decimal drivePath, string type) : base(factoryName, model, color, driveTime, drivePath)
        {
            Type = type;
        }

        public override decimal AverageSpeed()
        {
            return base.AverageSpeed();
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"tytpe : {Type}");
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override void DefineNatureHarmness()
        {
            Console.WriteLine("None");
        }
    }
}
