using Cursos.Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Cursos.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }


        public void Add(TEntity obj)
        {
            try
            {
                this.sqlContext.Set<TEntity>().Add(obj);
                this.sqlContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            //TODO: .net 6 usam o .ToList() estou testando esse .AsQueryable()
            return this.sqlContext.Set<TEntity>().AsQueryable();
        }

        public TEntity GetById(int id)
        {
            return this.sqlContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            try
            {
                this.sqlContext.Set<TEntity>().Remove(obj);
                this.sqlContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                //this.sqlContext.Entry(obj).State = EntityState.Modified;

                this.sqlContext.Set<TEntity>().Update(obj);
                this.sqlContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
