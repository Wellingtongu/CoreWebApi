using CoreWebApi.Domain.Interfaces;
using CoreWebApi.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreWebApi.Infra.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly CoreWebApiContext Db;

        protected readonly DbSet<TEntity> DbSet;

        public Repository(CoreWebApiContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
            Db.SaveChanges();
        }

        public virtual TEntity GetById(int id)
        {
            var entity = DbSet.Find(id);
            if (entity != null)
                Db.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public virtual void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
            Db.SaveChanges();
        }
    }
}
