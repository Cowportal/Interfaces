﻿using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("car: c");
            Car c = new Car(true);
            c.SteerLeft();

            Console.WriteLine("car: car");
            Car car = new Car();
            Console.WriteLine(car.IsOn);
            car.Start();
            c.SteerLeft();
            Console.WriteLine(car.IsOn);

            //with private set doesn't work
            //car.IsOn = false;
            car.Stop();
            Console.WriteLine(car.IsOn);

            Console.WriteLine("Motorbike: moto");
            MotorBike moto = new MotorBike();
            moto.Start();
            c.SteerLeft();
            Console.WriteLine(moto.IsOn);

            Console.WriteLine("Motorbike: moto2");
            MotorBike moto2 = new MotorBike(true);
            Console.WriteLine(moto2.IsOn);
            moto2.Stop();
            Console.WriteLine(moto2.IsOn);

            Console.ReadLine();

        }

    }
}