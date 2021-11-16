using System.Collections.Generic;

namespace DomainLibrary.Entities
{
    public class Category
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Note> Item { get; set; }
    }
}
