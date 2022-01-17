using Microsoft.EntityFrameworkCore;
using DomainLibrary.Entities;


namespace DataAccess
{
    public class Context : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Template> Templates { get; set; }

        public DbSet<User> Users { get; set; }

        public Context() : base()
        {
            //some logic
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EzNoteDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<Note>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Note>()
                .Property(p => p.TextPlace)
                .HasMaxLength(9999);

            modelBuilder.Entity<Note>()
                .Property(p => p.Description)
                .HasMaxLength(80);

            modelBuilder.Entity<Note>()
                .HasMany(p => p.Categories)
                .WithMany(v => v.CategoryItem);
            

            modelBuilder.Entity<Category>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<Category>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Category>()
                .Property(p => p.Description)
                .HasMaxLength(80);

            modelBuilder.Entity<Category>()
                .HasMany(p => p.CategoryItem)
                .WithMany(v => v.Categories);


            modelBuilder.Entity<Template>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<Template>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Template>()
                .Property(p => p.Description)
                .HasMaxLength(80);

            modelBuilder.Entity<Template>()
                .Property(p => p.Note)
                .IsRequired();


            modelBuilder.Entity<User>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<User>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(40);

            modelBuilder.Entity<User>()
                .Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .Property(p => p.DateOfBirth)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(p => p.PhoneNumber)
                .HasMaxLength(12)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(p => p.Email)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(p => p.Country)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
