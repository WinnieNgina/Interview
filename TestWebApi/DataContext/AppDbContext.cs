using Microsoft.EntityFrameworkCore;
using TestWebApi.Models;

namespace TestWebApi.DataContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Person> Persons { get; set; }
}
