using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private int capacity;
        private int comfort;
        private ICollection<IDecoration> decorations;
        private ICollection<IFish> fish;

        public Aquarium(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.decorations = new List<IDecoration>();
            this.fish = new List<IFish>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Aquarium name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }
        public int Comfort 
        {
            get
            {
                return this.decorations.Sum(d => d.Comfort);
            }
            
        }

        public ICollection<IDecoration> Decorations => this.decorations;

        public ICollection<IFish> Fish => this.fish;

        public void AddDecoration(IDecoration decoration)
        {
            this.decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (this.fish.Count >= this.capacity)
            {
                throw new InvalidOperationException("Not enough capacity.");
            }
            this.fish.Add(fish);
        }

        public void Feed()
        {
            foreach (var fish in fish)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.name} ({this.GetType().Name}):");

            if (this.fish.Count == 0)
            {
                sb.AppendLine("Fish: none");
            }

            else
            {
                var fishes = this.fish.Select(f => f.Name).ToList();

                sb.AppendLine($"Fish: {string.Join(", ", fishes)}");
            }

            sb.AppendLine($"Decorations: {this.decorations.Count}");
            sb.AppendLine($"Comfort: {this.Comfort}");

            return sb.ToString().TrimEnd();

        }

        public bool RemoveFish(IFish fish)
        {
            return this.fish.Remove(fish);
        }
    }
}
