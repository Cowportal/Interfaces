using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    abstract class Automobile
    {
        // field ALWAYS private
        private bool _isOn;


        // property - ALWAYS public except
        //set cause we have a method for this
        public bool IsOn
        {
            get { return _isOn; }
            private protected set { _isOn = value; }

        }

        public Automobile()
        {

        }

        public Automobile(bool IsOn)
        {
            this._isOn = IsOn;
        }

        public void Start()
        {
            this._isOn = true;
        }

        public void Stop()
        {
            this._isOn = false;
        }

        abstract public void SteerLeft();  //anagkazw (abstract = contract) auto pou klhronomei (inherit) thn automobile na kanei steerleft
        //abstract public void SteerRight();
        //abstract public void Steer(bool steerLeft);

    }
}