using System;
using System.Collections.Generic;
using System.Text;

namespace Task_A
{
    internal class Vehicle
    {
        public string Color;
        public string Brand;
        public int Millage;
        public Vehicle[] Cars = new Vehicle[0];



        public virtual void Showinfo()
        {
            Console.WriteLine($"Color:{Color} Brand:{Brand} Millage:{Millage}");
        }
        public virtual void Drive()
        {
            Console.WriteLine("Vehicle");   
        }
        public void Add(Vehicle emp)
        {
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = emp;
        }

        public Vehicle[] GetArray()
        {
            return Cars;
        }


    }
}
