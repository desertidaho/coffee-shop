using System.Collections.Generic;
using tshirts.Models;

namespace tshirts.DataBase
{
  public static class Data
  {
    public static List<Tshirt> Inventory = new List<Tshirt>()
    {
      new Tshirt(1234, "Espresso", "Dark shirts with even darker sense of humor sayings.", 22.00m),
      new Tshirt(1235, "Americano", "Classic cut tees with our shop logo.", 19.00m),
      new Tshirt(1236, "Breve", "Super rich and creamy, ie soft cotton tee in light colors.", 20.00m)
    };
  }
}