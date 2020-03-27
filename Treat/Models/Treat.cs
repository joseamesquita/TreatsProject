using System.Collections.Generic;

namespace Treat.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<TreatsFlavor>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<TreatsFlavor> Flavors { get; set; }
  }
}