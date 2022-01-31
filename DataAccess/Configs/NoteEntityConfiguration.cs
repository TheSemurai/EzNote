using DomainLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataAccess.Configs
{
    public class NoteEntityConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder
                .HasKey(k => k.Id);

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(p => p.TextPlace)
                .HasMaxLength(9999);

            builder
                .Property(p => p.Description)
                .HasMaxLength(80);

            builder
                .HasMany(p => p.Categories)
                .WithMany(v => v.CategoryItem);
        }
    }
}
