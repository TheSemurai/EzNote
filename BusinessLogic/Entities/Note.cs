using System;


namespace BusinessLogic.Entities
{
    public class Note
    {
        public string Name { get; set; }
        public string TextPlace { get; set; }
        public string Description { get; set; } = String.Empty;
        public Category Category { get; set; }

    }
}
