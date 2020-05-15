using System;
using UnityContainerDemo.Manufactureres;
using Unity;
using UnityContainerDemo.Interfaces;
using Unity.Injection;
using UnityContainerDemo.ManufacturerKeys;

namespace UnityContainerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RunCarWithKeyAndDriver();

        }
       public static void RunCarWithKeyAndDriver() 
        {
            var container = new UnityContainer(); 
            container.RegisterType<Driver>(new InjectionConstructor(new object[] { new Audi(), "Steve" })); 
            var driver = container.Resolve<Driver>(); 
            driver.RunCar();
        }

    }
}
