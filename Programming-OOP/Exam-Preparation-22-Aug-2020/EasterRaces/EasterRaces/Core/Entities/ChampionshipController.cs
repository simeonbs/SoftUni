using EasterRaces.Core.Contracts;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private readonly IRepository<IDriver> drivers;
        private readonly IRepository<ICar> cars;
        private readonly IRepository<IRace> race;
        public ChampionshipController()
        {
            this.drivers = new DriverRepository();
            this.cars = new CarRepository();
            this.race = new RaceRepository();
        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            IDriver driver = this.drivers.GetByName(driverName);
            ICar car = this.cars.GetByName(carModel);
            if (driver == null)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }
            if (car == null)
            {
                throw new InvalidOperationException($"Car {carModel} could not be found.");
            }
            
            driver.AddCar(car);
            return $"Driver {driverName} received car {carModel}.";
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            IRace race = this.race.GetByName(raceName);
            IDriver driver = this.drivers.GetByName(driverName);
            if (race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }
            if (driver == null)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }
            race.AddDriver(driver);
            return $"Driver {driverName} added in {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            ICar car = this.cars.GetByName(model);
            if (car != null)
            {
                throw new ArgumentException($"Car {model} is already created.");
            }

            if (type == "Muscle")
            {
                car = new MuscleCar(model, horsePower);
                
                return $"MuscleCar {model} is created.";
            }
            if (type == "Sports")
            {
                car = new SportsCar(model, horsePower);
                return $"SportsCar {model} is created.";
            }
            this.cars.Add(car);
            return "";
        }

        public string CreateDriver(string driverName)
        {
            IDriver driver = this.drivers.GetByName(driverName);
            if (driver != null)
            {
                throw new ArgumentException($"Driver {driverName} is already created.");
            }
            driver = new Driver(driverName);
            this.drivers.Add(driver);
            return $"Driver {driverName} is created.";
        }

        public string CreateRace(string name, int laps)
        {
            IRace race = this.race.GetByName(name);
            if (race != null)
            {
                throw new InvalidOperationException($"Race {name} is already create.");
            }
            //sledvashtiq red
            race = new Race(name, laps);
            this.race.Add(race);
            return $"Race {name} is created.";
        }

        public string StartRace(string raceName)
        {
            IRace race = this.race.GetByName(raceName);
            if (race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }
            if (race.Drivers.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }

            var sortedDrivers = race.Drivers.OrderByDescending(x => x.Car.CalculateRacePoints(race.Laps)).ToList();

            var first = sortedDrivers[0];
            var second = sortedDrivers[1];
            var third = sortedDrivers[3];

            this.race.Remove(race);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Driver {first} wins {raceName} race.");
            sb.AppendLine($"Driver {second} is second in {raceName} race.");
            sb.AppendLine($"Driver {third} is third in {raceName} race.");
            return sb.ToString().TrimEnd();
        }
    }
}
