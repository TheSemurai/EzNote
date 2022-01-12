using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Interfaces
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Insert(TEntity _repositoryObject);
        void Update(TEntity _repositoryObject);
        void Delete(int id);
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}
