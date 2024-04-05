using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Book> Books { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<Author> Authors { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Position> Positions { get; set; }
        DbSet<BankAccount> Accounts { get; set; }
    }
}
