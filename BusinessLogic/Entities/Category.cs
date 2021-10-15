using System;
using System.Collections.Generic;

namespace BusinessLogic.Entities
{
    public class Category
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Note> Item { get; set; }
    }
}
