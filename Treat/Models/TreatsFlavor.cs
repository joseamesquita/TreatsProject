namespace Treat.Models
{
  public class TreatsFlavor
  {
    public int TreatsFlavorId { get; set; }
    public int FlavorId { get; set; }
    public int TreatId { get; set; }
    public Flavor Flavor { get; set; }
    public Treat Treat { get; set; }
  }
}