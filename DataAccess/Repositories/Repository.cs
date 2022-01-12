using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using DomainLibrary.Entities;

namespace DataAccess.Services
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private Context _context;
        public Repository(Context context) => _context = context;

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return _context.Set<TEntity>().Where(predicate);
            }
            catch (Exception e)
            {
                throw new Exception($"Cannot find the {typeof(TEntity)}s with | {predicate.ToString()} | predicates.", e);
            }
        }

        public TEntity Get(int id)
        {
            try
            {
                return _context.Set<TEntity>().Find(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Cannot get {typeof(TEntity)} #{id}.", e);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _context.Set<TEntity>().Remove(Get(id));
            }
            catch (Exception e)
            {
                throw new Exception($"Cannot remove {typeof(TEntity)} #{id}.", e);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return _context.Set<TEntity>().ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Cannot get all {typeof(TEntity)}s.", e);
            }
        }

        public void Insert(TEntity _repositoryObject)
        {
            try
            {
                _context.Set<TEntity>().Add(_repositoryObject);
            }
            catch (Exception e)
            {
                throw new Exception($"Cannot add new {typeof(TEntity)}.", e);
            }
        }

        public void Update(TEntity _repositoryObject)
        {
            try
            {
                _context.Set<TEntity>().Update(_repositoryObject);
            }
            catch (Exception e)
            {
                throw new Exception($"Cannot update values of {typeof(TEntity)} obj: {_repositoryObject}.", e);
            }
        }

        public IQueryable<TEntity> AsQueryable()
        {
            try
            {
                return _context.Set<TEntity>().AsQueryable();
            }
            catch (Exception e)
            {
                throw new Exception($"Cannot return IQueryable<{typeof(TEntity)}>.", e);
            }
        }

        public IEnumerable<TEntity> AsEnumerable()
        {
            try
            {
                return _context.Set<TEntity>().AsEnumerable();
            }
            catch (Exception e)
            {
                throw new Exception($"Cannot return IEnumerable<{typeof(TEntity)}>.", e);
            }
        }
    }
}
