using DataAccess.Interfaces;
using DomainLibrary.Entities;


namespace DataAccess.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private Context _context;
        private IRepository<Note> _noteRepository;
        private IRepository<Category> _categoryRepository;
        private IRepository<Template> _templateRepository;
        private IRepository<User> _userRepository;

        public UnitOfWork(Context context) => this._context = context;

        public IRepository<Note> NoteRepository => _noteRepository ?? (_noteRepository = new Repository<Note>(_context));
        public IRepository<Category> CategoryRepository => _categoryRepository ?? (_categoryRepository = new Repository<Category>(_context));
        public IRepository<Template> TemplateRepository => _templateRepository ?? (_templateRepository = new Repository<Template>(_context));
        public IRepository<User> UserRepository => _userRepository ?? (_userRepository = new Repository<User>(_context));

        public void Save() => _context.SaveChanges();
    }
}
