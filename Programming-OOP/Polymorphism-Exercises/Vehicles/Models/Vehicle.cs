using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public abstract class Vehicle
    {

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public string Drive(double distance)
        {
            double fuelNeeded = this.FuelConsumption * distance;
            if (this.FuelQuantity < fuelNeeded)
            {
                throw new ArgumentException
                    ($"{this.GetType().Name} travelled {distance} km");
            }
            this.FuelQuantity -= fuelNeeded;
            return $"{this.GetType().Name} travelled { distance} km";
        }

        public void Refuel(double liters)
        {
            if (this.GetType().Name == "Truck")
            {
                this.FuelQuantity += liters * 0.95;
            }
            else
            {
                this.FuelQuantity += liters;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
