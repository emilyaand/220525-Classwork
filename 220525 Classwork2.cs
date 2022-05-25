using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220525_Classwork
{
    class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        
        public readonly int MaxSpeed;


        public Car (int maxSpeed)
        {
            if (maxSpeed > 0)
            {
                MaxSpeed = maxSpeed;
            }
            else MaxSpeed = 140;        
        }   
    }
}
