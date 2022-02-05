using DomainLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataAccess.Configs
{
    class TemplateEntityConfiguration : IEntityTypeConfiguration<Template>
    {
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            builder
                .HasKey(k => k.Id);

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(p => p.Description)
                .HasMaxLength(80);

            builder
                .HasOne(h => h.Note)
                .WithMany()
                .IsRequired();
        }
    }
}
