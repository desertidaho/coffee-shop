using System.Collections.Generic;

namespace tshirts.Models
{
  public class Order
  {
    public int Id { get; set; }
    public List<LineItem> Invoice { get; set; } = new List<LineItem>();
  }
}