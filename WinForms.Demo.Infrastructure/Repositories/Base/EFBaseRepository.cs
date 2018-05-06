using Dinjo.Base.Contracts.Repositories;
using Dinjo.Base.Domain;
using Dinjo.Base.Infrastructure.Repositories;
using Dinjo.Base.Specifications;
using Dinjo.Base.Utils;
using Dinjo.Logs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Core.Domain.Shared;

namespace WinForms.Demo.Infrastructure.Repositories.Base
{
    public abstract class EFBaseRepository<T>: BaseRepository, IRepository<T> where T : Entity
    {
        protected DbTodosContext.DbSetEnum dbSet;

        public EFBaseRepository(ILogger iLogger, DbTodosContext.DbSetEnum dbSet) : base(iLogger)
        {
            this.dbSet = dbSet;
        }

        public virtual T Add(T entity)
        {
            T toReturn = default(T);
            using (var db = new DbTodosContext())
            {
                var set = db.GetDbSet<T>(dbSet);
                toReturn = set.Add(entity);
                db.SaveChanges();
            }
            return toReturn;
        }

        public T Delete(T entity)
        {
            using (var db = new DbTodosContext())
            {
                var teamMemberDb = db.GetDbSet<T>(dbSet).First(t => t.Id == entity.Id);
                db.GetDbSet<T>(dbSet).Remove(teamMemberDb);
                db.SaveChanges();
                return teamMemberDb;
            }
        }

        public virtual T Get(Specification<T> specification = null)
        {
            using (var db = new DbTodosContext())
            {
                specification = specification ?? new AllRecordsSpecification<T>();
                return db.GetDbSet<T>(dbSet).FirstOrDefault(specification.ToExpression());
            }
        }

        public virtual List<T> GetList(Specification<T> specification = null)
        {
            using (var db = new DbTodosContext())
            {
                specification = specification ?? new AllRecordsSpecification<T>();
                return db.GetDbSet<T>(dbSet).Where(specification.ToExpression()).ToList();
            }
        }

        public virtual T Update(T entity)
        {
            using (var db = new DbTodosContext())
            {
                var teamMemberDb = db.GetDbSet<T>(dbSet).First(t => t.Id == entity.Id);
                ReflectionUtil.MergeObjects(teamMemberDb, entity);
                db.SaveChanges();
                return teamMemberDb;
            }
        }
    }
}
