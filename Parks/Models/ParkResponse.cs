using Parks.Models;

namespace Parks
{
  public class ParkResponse
  {
    public List<Park> Parks { get; set; } = new List<Park>();
    public int Pages { get; set; }
    public int CurrentPage { get; set; }
  }
}