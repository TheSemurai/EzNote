﻿namespace DomainLibrary.Entities
{
    public class Template
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Note Note { get; set; }
    }
}
