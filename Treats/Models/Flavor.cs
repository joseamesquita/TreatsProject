
using System.Collections.Generic;

namespace Treats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<TreatsFlavor>();
    }

    public int FlavorId { get; set; }
    public string Description { get; set; }
    public ApplicationUser User { get; set; }
    public ICollection<TreatsFlavor> Treats { get; }
  }
}