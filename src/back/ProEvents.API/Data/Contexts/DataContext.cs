using Microsoft.EntityFrameworkCore;
using ProEvents.API.Models;

namespace ProEvents.API.Data.Contexts;

public class DataContext : DbContext
{
    public DbSet<Event> Events { get; set; }

    public DataContext(DbContextOptions options) : base(options)
    {
    }
}
