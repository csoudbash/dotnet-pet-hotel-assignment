using System;
using System.Linq; // FirstOrDefault() comes from here
using Microsoft.AspNetCore.Mvc;
using pet_hotel.Models;

namespace pet_hotel.Controllers;

[ApiController]
[Route("api/pets")]
public class CheckinController : ControllerBase
{
  private readonly ApplicationContext _context;
  public CheckinController(ApplicationContext context)
  {
    _context = context;
  }

  [HttpPut("{id}/checkIn")]
  public ActionResult<Pet> CheckIn(int id)
  {
    try
    {
      Pet pet = _context.Pets.FirstOrDefault(p => p.id == id);
      pet.checkedInAt = DateTime.Now;
      _context.Update(pet);
      _context.SaveChanges();
      return pet;
    }
    catch (Exception err)
    {
      Console.WriteLine("Error in pets checkIn router", err);
      return StatusCode(500);
    }
  }

  [HttpPut("{id}/checkOut")]
  public ActionResult<Pet> CheckOut(int id)
  {
    try
    {
      Pet pet = _context.Pets.FirstOrDefault(p => p.id == id);
      pet.checkedInAt = null;
      _context.Update(pet);
      _context.SaveChanges();
      return pet;
    }
    catch (Exception err)
    {
      Console.WriteLine("Error in pets checkOut router", err);
      return StatusCode(500);
    }
  }
}