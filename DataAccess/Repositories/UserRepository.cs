using DataAccess.Interfaces;
using DomainLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class UserRepository : IRepository<User>
    {
        private Context _context;

        public UserRepository(Context context) => _context = context;

        public void Delete(User _repositoryObject)
        {
            _context.Users.Remove(_repositoryObject);
        }

        public ICollection<User> GetAll()
        {
            return (ICollection<User>)_context.Users.ToList();
        }

        public User GetById(int Id)
        {
            var _users = _context.Users.Where(x => x.Id == Id).FirstOrDefault();
            return _users;
        }

        public void Insert(User _repositoryObject)
        {
            _context.Users.Add(_repositoryObject);
        }

        public void Update(User _repositoryObject)
        {
            _context.Users.Update(_repositoryObject);
        }
    }
}
