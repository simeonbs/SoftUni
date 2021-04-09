using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class DriverRepository : IRepository<IDriver>
    {
        private readonly List<IDriver> list;
        public DriverRepository()
        {
            this.list = new List<IDriver>();
        }
        public void Add(IDriver model) => this.list.Add(model);

        public IReadOnlyCollection<IDriver> GetAll()
            => this.list.ToList();

        public IDriver GetByName(string name) => this.list.FirstOrDefault(x => x.Name == name);

        public bool Remove(IDriver model) => this.list.Remove(model);
    }
}
