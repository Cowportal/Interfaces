using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Boat : Automobile
    {
        public Boat()
        {

        }
        public Boat(bool IsOn)
        {
            this.IsOn = IsOn;
        }
        public override void SteerLeft()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            Console.WriteLine("The boat is reversing");
        }
    }
}
