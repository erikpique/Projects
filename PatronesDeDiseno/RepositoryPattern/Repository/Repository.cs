using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.CompilerServices;
using RepositoryPattern.Model;

namespace RepositoryPattern.Repository
{
    public class Repository : IRepository<Anuncios, int>
    {
        public EntitiesDB context { get; set; }
        public IEnumerable<Anuncios> Get()
        {
            return context.Anuncioss.ToList();
        }

        public Anuncios Get(int id)
        {
            return context.Anuncioss.Find(id);
        }

        public void Add(Anuncios entity)
        {
            context.Anuncioss.Add(entity);
            context.SaveChanges();
        }

        public void Remove(Anuncios entity)
        {
            var obj = context.Anuncioss.Find(entity.Id);
            context.Anuncioss.Remove(obj);
            context.SaveChanges();
        }

        public void Update(Anuncios entity)
        {
            throw new System.NotImplementedException();
        }
    }
}