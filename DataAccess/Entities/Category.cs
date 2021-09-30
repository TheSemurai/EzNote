using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class Category
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Note> Item { get; set; }
    }
}
