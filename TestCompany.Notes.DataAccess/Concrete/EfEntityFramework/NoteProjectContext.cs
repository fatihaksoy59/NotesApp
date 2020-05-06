using Microsoft.EntityFrameworkCore;
using TestCompany.Notes.DataAccess.Concrete.EfEntityFramework.Mappings;
using TestCompany.Notes.Entities.Concrete;

namespace TestCompany.Notes.DataAccess.Concrete.EfEntityFramework
{
    public class NoteProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=NoteProject;Integrated Security=True;Connect Timeout=30;" +
                "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Note> Notes { get; set; }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NoteMap());

            modelBuilder.Entity<Person>().HasKey(p => p.Id);
            modelBuilder.Entity<Person>().Property(p => p.Id).UseIdentityColumn();
        }
    }
}