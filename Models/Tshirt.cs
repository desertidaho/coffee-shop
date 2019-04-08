using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tshirts.Models
{
  public class Tshirt
  {
    [Required]
    [Range(1, 1000)]
    public int Id { get; set; }

    [Required]
    [MinLength(2)]
    public string Name { get; set; }

    [MinLength(5)]
    public string Description { get; set; }

    [Required]
    public decimal Price { get; set; }

    public Tshirt(int id, string name, string description, decimal price)
    {
      Id = id;
      Name = name;
      Description = description;
      Price = price;
    }
  }
}