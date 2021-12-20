using DataAccess.Interfaces;
using DataAccess.Repositories;
using DomainLibrary.Entities;
 

namespace DataAccess.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private Context _context;
        private NoteRepository _noteRepository;
        private CategoryRepository _categoryRepository;
        private TemplateRepository _templateRepository;
        private UserRepository _userRepository;

        public UnitOfWork(Context context)
        {
            this._context = context;
        }

        public IRepository<Note> NoteRepository 
        {
            get
            {
                return _noteRepository = _noteRepository ?? new NoteRepository(_context);
            }
        }

        public IRepository<Category> CategoryRepository
        {
            get
            {
                return _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);
            }
        }

        public IRepository<Template> TemplateRepository
        {
            get
            {
                return _templateRepository = _templateRepository ?? new TemplateRepository(_context);
            }
        }

        public IRepository<User> UserRepository
        {
            get
            {
                return _userRepository = _userRepository ?? new UserRepository(_context);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
