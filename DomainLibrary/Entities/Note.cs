using System;

namespace DomainLibrary.Entities
{
    public class Note
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string TextPlace { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }

    }
}
