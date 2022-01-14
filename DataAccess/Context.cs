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
            //some logic
        }
    }
}
