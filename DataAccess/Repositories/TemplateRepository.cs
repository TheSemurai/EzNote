using DataAccess.Interfaces;
using DomainLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class TemplateRepository : IRepository<Template>
    {
        private Context _context;

        public TemplateRepository(Context context) => _context = context;

        public void Delete(Template _repositoryObject)
        {
            _context.Templates.Remove(_repositoryObject);
        }

        public ICollection<Template> GetAll()
        {
            return (ICollection<Template>)_context.Templates.ToList();
        }

        public Template GetById(int Id)
        {
            var _templates = _context.Templates.Where(x => x.Id == Id).FirstOrDefault();
            return _templates;
        }

        public void Insert(Template _repositoryObject)
        {
            _context.Templates.Add(_repositoryObject);
        }

        public void Update(Template _repositoryObject)
        {
            _context.Templates.Update(_repositoryObject);
        }
    }
}
