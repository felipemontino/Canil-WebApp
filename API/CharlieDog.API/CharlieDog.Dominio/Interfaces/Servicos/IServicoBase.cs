using System.Collections.Generic;

namespace CharlieDog.Dominio.Interfaces.Services
{
    public interface IServicoBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
