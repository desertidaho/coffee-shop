using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using tshirts.DataBase;
using tshirts.Models;

namespace tshirts.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TshirtController : ControllerBase
  {
    //Bad, don't do this
    List<Tshirt> Inventory = Data.Inventory;

    //Get all api/tshirt
    [HttpGet]
    public ActionResult<List<Tshirt>> Get()
    {
      return Inventory;
    }

    //Get by Id
    [HttpGet("{id}")]
    public ActionResult<List<Tshirt>> GetById(int id)
    {
      Tshirt found = Inventory.Find(t => t.Id == id);
      if (found != null)
      {
        return found;
      }
      return BadRequest("{\"error\": \"not found\"}");
    }

    [HttpPost]
    public ActionResult<List<Tshirt>> Post([FromBody] Tshirt value)
    {
      Inventory.Add(value);
      return Inventory;
    }

    // api/tshirt/:id
    [HttpPut("{id}")]
    public ActionResult<Tshirt> Put(int id, [FromBody] Tshirt newData)
    {
      // add newData in place of old data
      Tshirt oldData = Inventory.Find(t => t.Id == id);
      if (oldData == null) { return BadRequest(); }
      Inventory.Remove(oldData);
      Inventory.Add(newData);
      return newData;
    }

    [HttpDelete("{id")]
    public ActionResult Delete(int id)
    {
      Tshirt oldData = Inventory.Find(t => t.Id == id);
      if (oldData == null) { return BadRequest(); }
      Inventory.Remove(oldData);
      return Ok();
    }
  }
}