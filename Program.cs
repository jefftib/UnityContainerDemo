using System;
using UnityContainerDemo.Manufactureres;
using Unity;
using UnityContainerDemo.Interfaces;
using Unity.Injection;
using UnityContainerDemo.ManufacturerKeys;
using Unity.Lifetime;

namespace UnityContainerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           /* BasisVoorbeeld();
            WithContainer();
            newDriverIsNewBMW();
            alwaysAudi();
            registerWithName();
            registerInstance();
            meerdereParameters();
            injectedParameters();
            ExplicitTransManager();
            ContainerControlledLTM();
            HierchicalLTM();*/
            RunCarWithKeyAndDriver();

        }



     /*   public static void BasisVoorbeeld() 
        {
            Driver driver = new Driver(new BMW()); 
            driver.RunCar();
        }

        public static void WithContainer() 
        {
            IUnityContainer container = new UnityContainer();
            // Register BMW with ICar
            container.RegisterType<ICar, BMW>();
           
            // Resolves dependencies and returns the Driver object 
            Driver drv = container.Resolve<Driver>();
            drv.RunCar();
        }

        public static void newDriverIsNewBMW() 
        {
            var container = new UnityContainer();
            container.RegisterType<ICar, BMW>(); 
            Driver driver1 = container.Resolve<Driver>();
            driver1.RunCar();
          Driver driver2 = container.Resolve<Driver>();
            driver2.RunCar();
        }

        public static void alwaysAudi() 
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>(); 
            container.RegisterType<ICar, Audi>();
            Driver driver = container.Resolve<Driver>();
            driver.RunCar();
        }

        public static void registerWithName() 
        {
            var container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>("LuxuryCar");// Registers Driver type 
            container.RegisterType<Driver>("LuxuryCarDriver", new InjectionConstructor(container.Resolve<ICar>("LuxuryCar")));
            Driver driver1=container.Resolve<Driver>();// injects BMW
            driver1.RunCar();
            Driver driver2=container.Resolve<Driver>("LuxuryCarDriver");// injects Audi
            driver2.RunCar();
        }

        public static void registerInstance() 
        {
            var container = new UnityContainer();
            ICar audi = new Audi();
            container.RegisterInstance<ICar>(audi); 
            Driver driver1 = container.Resolve<Driver>(); 
            driver1.RunCar(); 
            driver1.RunCar();
            Driver driver2 = container.Resolve<Driver>();
            driver2.RunCar();
        }

        public static void constructieInjectie() 
        {
            var container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
            var driver = container.Resolve<Driver>();
            driver.RunCar();
        }

        public static void meerdereParameters() 
        {
            var container = new UnityContainer();
            container.RegisterType<ICar, Audi>(); 
            container.RegisterType<ICarKey, AudiKey>(); 
            var driver = container.Resolve<Driver>();
            driver.RunCar();
        }

        public static void injectedParameters() 
        {
            var container = new UnityContainer(); 
            container.RegisterType<Driver>(new InjectionConstructor(new object[] { new Audi(), "Steve" }));
            var driver = container.Resolve<Driver>(); // Injects Audi and Stevedriver.RunCar();
        }

        public static void ExplicitTransManager() 
        {
            var container = new UnityContainer().RegisterType<ICar, BMW>(new TransientLifetimeManager());
            var driver1 = container.Resolve<Driver>();
            driver1.RunCar();
            var driver2 = container.Resolve<Driver>();
            driver2.RunCar();
        }

        public static void ContainerControlledLTM() 
        {
            var container = new UnityContainer().RegisterType<ICar, BMW>(new ContainerControlledLifetimeManager()); 
            var driver1 = container.Resolve<Driver>();
            driver1.RunCar();
            var driver2 = container.Resolve<Driver>();
            driver2.RunCar();
        }

        public static void HierchicalLTM() 
        {
            var container = new UnityContainer().RegisterType<ICar, BMW>(new HierarchicalLifetimeManager());
            var childContainer = container.CreateChildContainer(); 
            var driver1 = container.Resolve<Driver>(); 
            driver1.RunCar();
            var driver2 = container.Resolve<Driver>(); 
            driver2.RunCar(); 
            var driver3 = childContainer.Resolve<Driver>();
            driver3.RunCar();
            var driver4 = childContainer.Resolve<Driver>();
            driver4.RunCar();
        }*/

       public static void RunCarWithKeyAndDriver() 
        {
            var container = new UnityContainer(); 
            container.RegisterType<Driver>(new InjectionConstructor(new object[] { new Audi(), "Steve" })); 
            var driver = container.Resolve<Driver>(); 
            driver.RunCar();
        }

    }
}
