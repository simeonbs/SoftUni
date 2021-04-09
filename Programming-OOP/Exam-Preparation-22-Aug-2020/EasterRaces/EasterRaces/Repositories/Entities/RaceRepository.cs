using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class RaceRepository : IRepository<IRace>
    {
        private readonly List<IRace> list;
        public RaceRepository()
        {
            this.list = new List<IRace>();
        }
        public void Add(IRace model) => this.list.Add(model);

        public IReadOnlyCollection<IRace> GetAll()
            => this.list.ToList();

        public IRace GetByName(string name) => this.list.FirstOrDefault(x => x.Name == name);

        public bool Remove(IRace model) => this.list.Remove(model);
    }
}
