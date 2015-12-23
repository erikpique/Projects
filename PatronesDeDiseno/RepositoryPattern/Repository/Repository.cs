using System.Collections.Generic;
using System.Data;
using System.Linq;
using RepositoryPattern.Model;

namespace RepositoryPattern.Repository
{
    public class Repository : IRepository<Anuncios>
    {
        private EntitiesDB context = new EntitiesDB();
        public IEnumerable<Anuncios> Get()
        {
            return context.Anuncios1.ToList();
        }

        public Anuncios Get(int? id)
        {
            return context.Anuncios1.Find(id);
        }

        public void Add(Anuncios entity)
        {
            var obj = new Anuncios()
            {
                Autor = entity.Autor,
                Anuncio = entity.Anuncio,
                Email = entity.Email,
                Tipo = entity.Tipo
            };
            
            context.Anuncios1.Add(obj);
            context.SaveChanges();
        }

        public void Remove(Anuncios entity)
        {
            var obj = context.Anuncios1.Find(entity.Id);
            context.Anuncios1.Remove(obj);
            context.SaveChanges();
        }

        public void Update(Anuncios entity)
        {
            var obj = context.Anuncios1.Find(entity.Id);
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}