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
      pet.checkedInAt = DateTime.Now; // changes the checkIn time to now
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
      Pet pet = _context.Pets.FirstOrDefault(p => p.id == id); // get the pet
      pet.checkedInAt = null; // change checkIn time to null when checked out
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