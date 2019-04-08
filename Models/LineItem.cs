using System.ComponentModel.DataAnnotations;

namespace tshirts.Models
{
  public class LineItem
  {
    public int Id { get; set; }

    [Range(1, 15)]
    public int Quantity { get; set; }
  }
}