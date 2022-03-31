using System;
using System.Collections.Generic;
using System.Text;

namespace Task_A
{
    internal class Car : Vehicle
    {
        public string FuelCapacity;
        public int CurrentFuel;
        public int FuelFor1km;
        

       
        public override void Showinfo()
        {
            base.Showinfo();
        }
        public override void Drive(int m)
        {
            if (CurrentFuel > 0)
            {
                Millage++;
                CurrentFuel=CurrentFuel-m*FuelFor1km;
            }
            else
            {
                Console.WriteLine("Benzin bitdi");
            }
        }
        public override string ToString()
        {
            return $"Color:{Color} Brand:{Brand} Millage:{Millage} FuelCapacity:{FuelCapacity} CurrentFuel:{CurrentFuel} FuelFor1km:{FuelFor1km} ";
        }
        
    }
}
