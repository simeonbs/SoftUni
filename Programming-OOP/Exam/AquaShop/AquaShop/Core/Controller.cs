using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Fish;
using AquaShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorations;
        private ICollection<IAquarium> aquariums;

        public Controller()
        {
            decorations = new DecorationRepository();
            aquariums = new List<IAquarium>();
        }


        public string AddAquarium(string aquariumType, string aquariumName)
        {
            if (aquariumType == "FreshwaterAquarium")
            {
                this.aquariums.Add(new FreshwaterAquarium(aquariumName));
                return $"Successfully added FreshwaterAquarium.";
            }
            //
            if (aquariumType == "SaltwaterAquarium")
            {
                this.aquariums.Add(new SaltwaterAquarium(aquariumName));
                return $"Successfully added SaltwaterAquarium.";
            }
            //
            else
            {
                throw new InvalidOperationException("Invalid aquarium type.");
            }
        }

        public string AddDecoration(string decorationType)
        {
            if (decorationType == "Ornament")
            {
                this.decorations.Add(new Ornament());
                return "Successfully added Ornament.";
            }
            if (decorationType == "Plant")
            {
                this.decorations.Add(new Plant());
                return "Successfully added Plant.";
            }
            else
            {
                throw new InvalidOperationException("Invalid decoration type.");
            }
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            if (fishType != "FreshwaterFish" && fishType != "SaltwaterFish")
            {
                throw new InvalidOperationException("Invalid fish type.");
            }

            var aquarium = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);
            if (aquarium.GetType().Name == "FreshwaterAquarium" && fishType == "SaltwaterFish" ||
                    aquarium.GetType().Name == "SaltwaterAquarium" &&
                    fishType == "FreshwaterFish")
            {
                return "Water not suitable.";
            }
            else
            {
                if (fishType == "FreshwaterFish")
                {
                    aquarium.AddFish(new FreshwaterFish(fishName, fishSpecies, price));
                }
                if (fishType == "SaltwaterFish")
                {
                    aquarium.AddFish(new SaltwaterFish(fishName, fishSpecies, price));
                }

                return $"Successfully added {fishType} to {aquariumName}.";

            }
        }

        public string CalculateValue(string aquariumName)
        {
            var aq = aquariums.FirstOrDefault(aq => aq.Name == aquariumName);
            var fishPrice = aq.Fish.Sum(d => d.Price);
            var decoPrice = aq.Decorations.Sum(d => d.Price);
            var sum = fishPrice + decoPrice;
            return $"The value of Aquarium {aquariumName} is {sum:f2}.";
        }

        public string FeedFish(string aquariumName)
        {
            var aquarium = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);

            foreach (var fish in aquarium.Fish)
            {
                fish.Eat();
            }

            var result = $"Fish fed: {aquarium.Fish.Count}";
            return result;
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            if (!this.decorations.Models.Any(d => d.GetType().Name == decorationType))
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
            }

            var decoration = this.decorations.Models.First(d => d.GetType().Name == decorationType);

            var aquarium = this.aquariums.Single(a => a.Name == aquariumName);

            aquarium.AddDecoration(decoration);

            this.decorations.Remove(decoration);

            return $"Successfully added {decorationType} to {aquariumName}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var aq in aquariums)
            {
                sb.AppendLine(aq.GetInfo());
            }
            return sb.ToString().TrimEnd();
        }
    }

}

