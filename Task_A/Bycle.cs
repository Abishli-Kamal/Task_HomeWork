using System;
using System.Collections.Generic;
using System.Text;

namespace Task_A
{
    internal class Bycle:Vehicle
    {
        public Bycle(string color, string brand, int millage) 
        {
            
        }
        public override string ToString()
        {
            return $"Color:{Color} Brand:{Brand} Millage:{Millage}";
        }
        public override void Drive(int m)
        {
            Millage--;
        }
    }
}
