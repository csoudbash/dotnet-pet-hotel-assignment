using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace pet_hotel.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class PetOwnersController : ControllerBase
  {
    private readonly ApplicationContext _context;
    public PetOwnersController(ApplicationContext context)
    {
      _context = context;
    }

    [HttpGet]
    public ActionResult<List<PetOwner>> Get()
    {
      try
      {
        return _context.PetOwners;
      }
      catch (Exception err)
      {
        Console.WriteLine("Error in get petowners", err);
        return NotFound();
      }
    }

    [HttpGet("{id}")]
    public ActionResult<PetOwner> Get(int id)
    {
      try
      {
        PetOwner petOwner = _context.PetOwners.FristOrDefault(po => po.id == id);
        return petOwner;
      }
      catch (Exception err)
      {
        Console.WriteLine(err);
        return NotFound();
      }
    }
  }
}
