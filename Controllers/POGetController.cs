using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace pet_hotel.Controllers
{
  [ApiController]
  [Route("api/petowners")]
  public class PetOwnersController : ControllerBase
  {
    private readonly ApplicationContext _context;
    public PetOwnersController(ApplicationContext context)
    {
      _context = context;
    }

    [HttpGet]
    public IEnumerable<PetOwner> Get()
    {
      return _context.PetOwners;
    }

    [HttpGet("{id}")]
    public ActionResult<PetOwner> Get(int id)
    {
      PetOwner petOwner = _context.PetOwners.FirstOrDefault(po => po.id == id);
      if (petOwner is null)
      {
        return StatusCode(204);
      }
      return petOwner;
    }
  }
}
