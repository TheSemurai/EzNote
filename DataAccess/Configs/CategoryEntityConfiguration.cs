using DomainLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataAccess
{
    class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasKey(k => k.Id);

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(p => p.Description)
                .HasMaxLength(80);

            builder
                .HasMany(p => p.CategoryItem)
                .WithMany(v => v.Categories);
        }
    }
}
