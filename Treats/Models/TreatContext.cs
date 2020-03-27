using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Treats.Models
{
  public class TreatContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatsFlavor> TreatsFlavor { get; set; }

    public TreatContext(DbContextOptions options) : base(options) { }
  }
}