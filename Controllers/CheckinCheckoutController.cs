using Microsoft.AspNetCore.Mvc;
using pet_hotel.Models;

namespace pet_hotel.Controllers;

[ApiController]
[Route("api/pets")]
class CheckinController : ControllerBase
{
  private readonly ApplicationContext _context;
  public CheckinController(ApplicationContext context)
  {
    _context = context;
  }

  [HttpPut("{id}/checkIn")]
  public ActionResult<Pet> CheckIn(int id, Pet pet)
  {
    return StatusCode(418);
  }
}