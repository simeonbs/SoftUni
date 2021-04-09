using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class CarRepository : IRepository<ICar>
    {
        private readonly List<ICar> list;
        public CarRepository()
        {
            this.list = new List<ICar>();
        }
        public void Add(ICar model) => this.list.Add(model);

        public IReadOnlyCollection<ICar> GetAll()
            => this.list.ToList();

        public ICar GetByName(string name) => this.list.FirstOrDefault(x => x.Model == name);

        public bool Remove(ICar model) => this.list.Remove(model);
    }
}
