using DataAccess.Interfaces;
using DomainLibrary.Entities;
using System.Collections.Generic;
using System.Linq;


namespace DataAccess.Repositories
{
    class CategoryRepository : IRepository<Category>
    {
        private Context _context;

        public CategoryRepository(Context context) => _context = context;

        public void Delete(Category _repositoryObject)
        {
            _context.Categories.Remove(_repositoryObject);
        }

        public ICollection<Category> GetAll()
        {
            return (ICollection<Category>)_context.Notes.ToList();
        }

        public Category GetById(int Id)
        {
            var _categories = _context.Categories.Where(x => x.Id == Id).FirstOrDefault();
            return _categories;
        }

        public void Insert(Category _repositoryObject)
        {
            _context.Categories.Add(_repositoryObject);
        }

        public void Update(Category _repositoryObject)
        {
            _context.Categories.Update(_repositoryObject);
        }
    }
}
