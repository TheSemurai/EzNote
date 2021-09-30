using System;


namespace DataAccess.Entities
{
    public class Note
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string TextPlace { get; set; }
        public string Description { get; set; } = String.Empty;
        public Category Category { get; set; }
    }
}
