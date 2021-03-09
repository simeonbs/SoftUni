using System;
using System.Linq;
using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carArray = Console.ReadLine().Split(" ").ToArray();
            string[] truckArray = Console.ReadLine().Split(" ").ToArray();

            Vehicle car = new Car(double.Parse(carArray[1]), double.Parse(carArray[2]));
            Vehicle truck = new Truck(double.Parse(truckArray[1]), double.Parse(truckArray[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ").ToArray();
                if (data[0] == "Drive")
                {
                    if (data[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(double.Parse(data[2])));
                    }
                    else if (data[1] == "Truck")
                    {
                        Console.WriteLine(truck.Drive(double.Parse(data[2])));
                    }
                }
                else
                {
                    try
                    {
                        if (data[1] == "Car")
                        {
                            car.Refuel(double.Parse(data[2]));
                        }
                        else
                        {
                            truck.Refuel(double.Parse(data[2]));
                        }
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
                
            }
        }
    }
}
