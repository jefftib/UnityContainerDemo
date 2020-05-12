using System;
using UnityContainerDemo.Manufactureres;

namespace UnityContainerDemo
{
    class Program
    {
        static void Main(string[] args)
        { //BasisVoorbeeld
            Driver driver = new Driver(new BMW());
            driver.RunCar();


        }
    }
}
