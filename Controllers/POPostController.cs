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
  public class PetOwnersPostController : ControllerBase
  {
    private readonly ApplicationContext _context;
    public PetOwnersPostController(ApplicationContext context)
    {
      _context = context;
    }

    [HttpPost]
    public ActionResult<PetOwner> Post(PetOwner petOwner)
    {
      _context.Add(petOwner);
      _context.SaveChanges();
      return petOwner;
    }
  }
}
