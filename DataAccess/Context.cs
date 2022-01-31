using Microsoft.EntityFrameworkCore;
using DomainLibrary.Entities;
using DataAccess.Configs;


namespace DataAccess
{
    public class Context : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Template> Templates { get; set; }

        public DbSet<User> Users { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            //TODO
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NoteEntityConfiguration());

            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());

            modelBuilder.ApplyConfiguration(new TemplateEntityConfiguration());

            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}
