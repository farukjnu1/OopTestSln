using OopTest.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle v = new Vehicle(); // you can't intiated this Vehicle class becasue it is a abstract class
            // in this case you will get a compile time error

            // input from user
            Console.WriteLine("choose vehicle:");
            Console.WriteLine("input '4' for car or input '2' for motorcycle");
            int vehicleType = int.Parse(Console.ReadLine());
            if (vehicleType == (int)VehicleType.FourWheeler)
            {

            }
            else if (vehicleType == (int)VehicleType.TwoWheeler)
            {
                Motorcycle oMotorcycle = new Motorcycle();
                Console.WriteLine("input CC:");
                oMotorcycle.EngineCapacityCC = int.Parse(Console.ReadLine());
                Console.WriteLine("input Milage:");
                oMotorcycle.MilagePowerNM = decimal.Parse(Console.ReadLine());
                Console.WriteLine("input Model Number:");
                oMotorcycle.ModelNo = Console.ReadLine();
                Console.WriteLine("input Year:");
                oMotorcycle.YearMake = int.Parse(Console.ReadLine());

                IExterior iExterior = new TwoWheeler();
                iExterior.DesignExterior(oMotorcycle);
            }
            else
            {
                Console.WriteLine("vehicle not found.");
            }

            Console.ReadLine();
        }
    }

    /*
     * in this case you will get error becasue 
     * Class that are marked with the sealed (C#) keywords cannot be inherited from. 
     * This is done at the definition of the classes.
    class Test:Motorcycle
    {

    }
    */

}
