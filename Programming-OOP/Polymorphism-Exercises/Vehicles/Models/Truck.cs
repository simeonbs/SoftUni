using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;

        public Truck(double fuelQuantity, double fuelConsumption)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }
        public double FuelConsumption
        {
            get
            {
                return fuelConsumption;
            }

            set
            {
                fuelConsumption = value + 1.6;
            }
        }
    }
}
