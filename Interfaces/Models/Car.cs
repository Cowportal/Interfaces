using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Car : Automobile
    {
        public Car()
        {

        }
        public Car (bool IsOn)
        {
            this.IsOn = IsOn;
        }

        public override void SteerLeft()
        {
            Console.WriteLine("The car is steering left");
        }
    }
}
