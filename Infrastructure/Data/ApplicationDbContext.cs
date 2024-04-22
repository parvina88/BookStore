using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Position> Positions { get; set; } = null!;
        public DbSet<BankAccount> Accounts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<BaseEntity>();
            modelBuilder.Ignore<Person>();

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
