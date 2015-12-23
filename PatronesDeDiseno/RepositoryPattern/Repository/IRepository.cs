using System.Collections.Generic;

namespace RepositoryPattern.Repository
{
    public interface IRepository<Anuncios>
    {
        IEnumerable<Anuncios> Get();
        Anuncios Get(int? id);
        void Add(Anuncios entity);
        void Remove(Anuncios entity);
        void Update(Anuncios entity);
    }
}