using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W
{ internal class vehicle
    {
        public string Brand { get; set; }
    }
    class MotorVehicle : vehicle
    {
        public string ModelName { get; set; }
    }
    class car : MotorVehicle
    {
        public car(string brand, string modelName)
        {
            Brand = brand;
            ModelName = modelName;
        }
        public void DisplaycarInfo()
        {
            Console.WriteLine("car Brand:" + Brand + "  " + " Model:" + ModelName);
        }

    }

    class Truck : MotorVehicle
    {
        public Truck(string brand, string modelName)
        {
            Brand = brand;
            ModelName = modelName;
        }
        public void DisplayTruckInfo()
        {

            Console.WriteLine("Truck Brand:" + Brand + "  " + "Model:" + ModelName);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car mycar = new car("BMW", "c400");
            Truck myTruck = new Truck("Mercedes", "v11");
            mycar.DisplaycarInfo();
            myTruck.DisplayTruckInfo();
            Console.ReadKey();


        }
    }
}
