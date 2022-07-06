using AB.CursoMvc.Domain.Interfaces;
using AB.CursoMvc.Domain.Models;
using AB.CursoMvc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AB.CursoMvc.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected CursoMvcContext Db;
        protected DbSet<TEntity> DbSet;

        protected Repository()
        {
            Db = new CursoMvcContext();
            DbSet = Db.Set<TEntity>();
        }

        public virtual TEntity Adicionar(TEntity obj)
        {
            var retEnt = DbSet.Add(obj);
            SaveChanges();
            return retEnt;
        }

        public virtual TEntity Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            SaveChanges();

            return obj;
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual IEnumerable<TEntity> ObterTodosPaginado(int s, int t)
        {
            return DbSet.Skip(s).Take(t).ToList();
        }

        public virtual void Remover(Guid id)
        {
            var obj = new TEntity() { Id = id };
            DbSet.Remove(obj);
            SaveChanges();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
        public void Dispose()
        {
            Db.Dispose();
        }

    }
}
