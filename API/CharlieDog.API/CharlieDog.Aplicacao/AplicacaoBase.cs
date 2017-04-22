using CharlieDog.Aplicacao.Interfaces;
using CharlieDog.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace CharlieDog.Aplicacao
{
    public class AplicacaoBase<TEntity> : IDisposable, IAplicacaoBase<TEntity> where TEntity : class
    {
        private readonly IServicoBase<TEntity> serviceBase;

        public AplicacaoBase(IServicoBase<TEntity> serviceBase)
        {
            this.serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return serviceBase.GetAll();
        }

        public void Update(TEntity obj)
        {
            serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            serviceBase.Remove(obj);
        }

        public void Dispose()
        {
            serviceBase.Dispose();
        }
    }
}
