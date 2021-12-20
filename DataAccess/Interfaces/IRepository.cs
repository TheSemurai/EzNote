using System.Collections.Generic;


namespace DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        ICollection<T> GetAll();
        T GetById(int Id);
        void Insert(T _repositoryObject);
        void Update(T _repositoryObject);
        void Delete(T _repositoryObject);
    }
}
