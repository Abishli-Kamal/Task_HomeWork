using System;

namespace Task_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Car Class:");

            //Console.WriteLine("Before Car:");
            //Console.WriteLine(car);
            //Console.WriteLine("After Car");
            //car.Drive();
            //Console.WriteLine(car);

            //Console.WriteLine("Bycle Class:");
            //Bycle bycle = new Bycle("Red","Mercedes",10);
            //Console.WriteLine("Before Bycle:");
            //Console.WriteLine(bycle);
            //bycle.Drive();
            //Console.WriteLine("After Bycle:");
            //Console.WriteLine(bycle);
            Car car = new Car();
            Console.Write("Count:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.Write("Color:");
            car.Color = Console.ReadLine();
            Console.Write("Brand:");
            car.Brand = Console.ReadLine();
            Console.Write("FuelCapacity:");
            car.FuelCapacity = Console.ReadLine();
            Console.Write("CurrentFuel:");
            car.CurrentFuel = Convert.ToInt32(Console.ReadLine());
            Console.Write("FuelFor1km:");
            car.FuelFor1km = Convert.ToInt32(Console.ReadLine());
            Console.Write("Millage:");
            car.Millage = Convert.ToInt32(Console.ReadLine());


            Vehicle vehicle = new Vehicle();
            vehicle.Add(car);
            foreach (var item in vehicle.GetArray())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("1. Maşınları millage-e göre filtirlə");
            Console.WriteLine("2. Bütün maşınları göstər");
            Console.WriteLine("3. Prosesi bitir");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                if (car.Millage > 100 && car.Millage < 500)
                {
                    Vehicle vehicle1 = new Vehicle();
                    vehicle1.Add(car);
                    foreach (var item in vehicle.GetArray())
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("Araliga daxil deyil");
                }
            }

            if (answer == 2)
            {
                Console.WriteLine(car);
            }
            if (answer == 3)
            {
                Console.WriteLine("Application Bitdi");
            }

        }
    }
}
