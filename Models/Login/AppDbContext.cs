using System.Data.Entity;
using Prosjekt.Models;

public class AppDbContext : DbContext
{
    public required DbSet<User> Users { get; set; }
}
