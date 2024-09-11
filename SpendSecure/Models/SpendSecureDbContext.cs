//namespace SpendSecure.Models
//{
//  public class SpendSecureDbContext:DbContext
//  {
//  }
//}

using Microsoft.EntityFrameworkCore;

namespace SpendSecure.Models
{
  public class SpendSecureDbContext : DbContext
  {
    public DbSet<Expense> Expenses { get; set; }
    public SpendSecureDbContext(DbContextOptions<SpendSecureDbContext> options)
        : base(options)
    {
    }

    // Define DbSet for your entities (e.g., SpendSecure models)
    // public DbSet<YourModel> YourModels { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //  base.OnModelCreating(modelBuilder);
    //  // Additional configuration (if needed)
    //}
  }
}
