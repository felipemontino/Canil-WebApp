

using CharlieDog.Dados.Contexto;
using CharlieDog.Dominio.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CharlieDog.Data.Repositorio
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        protected CharlieDogContexto Db;

        public RepositorioBase()
        {
            this.Db = this.CreateContexto();
        }

        public CharlieDogContexto CreateContexto()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CharlieDogContexto>();
            optionsBuilder.UseNpgsql("CharlieDog");

            return new CharlieDogContexto(optionsBuilder.Options);
        }

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            if(this.Db != null)
            {
                this.Db.Dispose();
            }
        }
    }
}
