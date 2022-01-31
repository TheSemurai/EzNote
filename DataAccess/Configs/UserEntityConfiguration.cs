using DomainLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataAccess
{
    class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(k => k.Id);

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(40);

            builder
                .Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.DateOfBirth)
                .IsRequired();

            builder
                .Property(p => p.PhoneNumber)
                .HasMaxLength(12)
                .IsRequired();

            builder
                .Property(p => p.Email)
                .IsRequired();

            builder
                .Property(p => p.Country)
                .IsRequired();
        }
    }
}
