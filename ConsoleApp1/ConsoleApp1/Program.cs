namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new("Volvo", "XC90", "Gray", 1.25m, 9.8m, 4, true);

            Car car2 = new("Ford", "Mustang", "Black", 2.3m, 21.2m, 2, false);

            Bicycle bicycle1 = new("Santa Cruz", "Hightower", "Yellow", 5.5m, 15.7m, "MTB");

            Bicycle bicycle2 = new("Giant", "GFR C/B", "Orange", 2.6m, 7.5m, "BMX");

            Vehicle[] vehicles = new Vehicle[0];

            Array.Resize(ref vehicles, vehicles.Length + 1);
            vehicles[vehicles.Length - 1] = car1;

            Array.Resize(ref vehicles, vehicles.Length + 1);
            vehicles[vehicles.Length - 1] = car2;

            Array.Resize(ref vehicles, vehicles.Length + 1);
            vehicles[vehicles.Length - 1] = bicycle1;

            Array.Resize(ref vehicles, vehicles.Length + 1);
            vehicles[vehicles.Length - 1] = bicycle2;

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }

            Console.WriteLine(car1.AverageSpeed());
            Console.WriteLine(car2.AverageSpeed());
            Console.WriteLine(bicycle1.AverageSpeed());
            Console.WriteLine(bicycle2.AverageSpeed());

            car1.GetInfo();
            car2.GetInfo();
            bicycle1.GetInfo();
            bicycle2.GetInfo();

            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());
            Console.WriteLine(bicycle1.ToString());
            Console.WriteLine(bicycle2.ToString());

            car1.DefineNatureHarmness();
            car2.DefineNatureHarmness();
            bicycle1.DefineNatureHarmness();
            bicycle2.DefineNatureHarmness();
        }
    }
}
