using System;
using System.Collections.Generic;
using BurgerShack.Models;
using BurgerShack.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurgerShack.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class ItemsController : ControllerBase
  {
    private readonly ItemsService _ims;
    public ItemsController(ItemsService ims)
    {
      _ims = ims;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Item>> Get()
    {
      try
      {
        return Ok(_ims.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Item> Get(string id)
    {
      try
      {
        return Ok(_ims.Get(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Item> Post([FromBody] Item newItem)
    {
      try
      {
        return Ok(_ims.Create(newItem));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }


    [HttpPut("{id}")]
    public ActionResult<Item> Edit(string id, [FromBody] Item editItemData)
    {
      try
      {
        editItemData.Id = id;
        return Ok(_ims.Edit(editItemData));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> Delete(string id)
    {
      try
      {
        return Ok(_ims.Delete(id));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }







  }
}