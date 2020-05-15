using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using UnityContainerDemo.Interfaces;

namespace UnityContainerDemo
{
    class Driver
    {

        private ICar _Car =null;
        private ICarKey _Key = null;
        private string _Name = string.Empty;
        public Driver(ICar car, ICarKey key, string name) 
        {
            _Car = car;
            _Key = key;
            _Name = name;

        }
        
        public void RunCar() 
        {
            Console.WriteLine("Running {0} with {1} - {2} mile driven by {3} ", _Car.GetType().Name, _Key.GetType().Name, _Car.Run(), _Name);
        }
    }
}

