using DataAccess.Interfaces;
using DomainLibrary.Entities;
using System.Collections.Generic;
using System.Linq;


namespace DataAccess.Repositories
{
    class NoteRepository : IRepository<Note>
    {
        private Context _context;

        public NoteRepository(Context context) => _context = context;

        public void Delete(Note _repositoryObject)
        {
            _context.Notes.Remove(_repositoryObject);
        }

        public ICollection<Note> GetAll()
        {
            return (ICollection<Note>)_context.Notes.ToList();
        }

        public Note GetById(int Id)
        {
            var _notes = _context.Notes.Where(x => x.Id == Id).FirstOrDefault();
            return _notes;
        }

        public void Insert(Note _repositoryObject)
        {
            _context.Notes.Add(_repositoryObject);
        }

        public void Update(Note _repositoryObject)
        {
            _context.Notes.Update(_repositoryObject);
        }
    }
}
