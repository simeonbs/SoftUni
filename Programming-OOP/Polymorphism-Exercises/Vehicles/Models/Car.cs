using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Contracts;

namespace Vehicles.Models
{
    public class Car : Vehicle, IVehicle 
    {
        private double fuelQuantity;
        private double fuelConsumption;

        public Car(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
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
                fuelConsumption = value + 0.9;
            }
        }


    }
}
