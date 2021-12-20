using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Services
{
    public abstract class Repository<T> : IRepository<T>
    {
        private Context _context;

        public Repository(Context context) => _context = context;

        public virtual void Delete(T _repositoryObject)
        {
            _context.Remove(_repositoryObject);
        }

        public ICollection<T> GetAll()
        {
            return (ICollection <T>) _context.Notes.ToList();
        }

        public virtual T GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public virtual void Insert(T _repositoryObject)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T _repositoryObject)
        {
            throw new NotImplementedException();
        }
    }
}
