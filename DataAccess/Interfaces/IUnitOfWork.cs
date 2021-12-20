using DomainLibrary.Entities;


namespace DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Note> NoteRepository { get; }
        IRepository<Category> CategoryRepository { get; }
        IRepository<Template> TemplateRepository { get; }
        IRepository<User> UserRepository { get; }
        void Save();
    }
}
