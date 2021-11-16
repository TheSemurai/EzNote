using System;
using DomainLibrary.Enums;

namespace DomainLibrary.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public bool Role { get; set; }
        public string Country { get; set; }
    }
}
