using System.Collections.Generic;
using tshirts.DataBase;

namespace tshirts.Models
{
  public class Receipt
  {
    //string name, decimal price
    public Dictionary<string, decimal> ItemTotals { get; set; }
    public decimal Total { get; set; }

    public Receipt(Order order)
    {
      Total = 0;
      ItemTotals = new Dictionary<string, decimal>();
      foreach (var lineItem in order.Invoice)
      {
        var tee = Data.Inventory.Find(t => t.Id == lineItem.Id);
        if (tee == null) { continue; }
        decimal subTotal = tee.Price * lineItem.Quantity;
        Total += subTotal;
        ItemTotals.Add(tee.Name, subTotal);
      }
    }
  }
}