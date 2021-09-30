using System;
using System.Collections.Generic;

namespace BusinessLogic.Entities
{
    public class Category
    {
        public string Name { get; set; }
        public List<Note> Item { get; set; }
    }
}
