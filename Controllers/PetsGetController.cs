using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace pet_hotel.Controllers
{
<<<<<<< HEAD
    [ApiController]
    [Route("api/pets")]
    public class PetsGetController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetsGetController(ApplicationContext context)
        {
            _context = context;
        }
=======
  [ApiController]
  [Route("api/pets")]
  public class PetsController : ControllerBase
  {
    private readonly ApplicationContext _context;
    public PetsController(ApplicationContext context)
    {
      _context = context;
    }
>>>>>>> a06de5ce48b6aeaa9bc2644901d1148ddadd5fb9

    [HttpGet]
    public IEnumerable<Pet> GetAll()
    {
      Console.WriteLine("Get all pets");

      return _context.Pets
          .Include(PetOwner => PetOwner.OwnedBy);
    }

    [HttpGet("{id}")]
    public ActionResult<Pet> GetById(int id)
    {
      Pet pet = _context.Pets.Include(PetOwner => PetOwner.OwnedBy)
          .SingleOrDefault(pet => pet.id == id);

      if (pet is null)
      {
        return StatusCode(418); // send status 418
      }
      return pet;
    }

    // This is just a stub for GET / to prevent any weird frontend errors that 
    // occur when the route is missing in this controller
    // [HttpGet]
    // public IEnumerable<Pet> GetPets() {
    //     return new List<Pet>();
    // }

    // [HttpGet]
    // [Route("test")]
    // public IEnumerable<Pet> GetPets() {
    //     PetOwner blaine = new PetOwner{
    //         name = "Blaine"
    //     };

    //     Pet newPet1 = new Pet {
    //         name = "Big Dog",
    //         petOwner = blaine,
    //         color = PetColorType.Black,
    //         breed = PetBreedType.Poodle,
    //     };

    //     Pet newPet2 = new Pet {
    //         name = "Little Dog",
    //         petOwner = blaine,
    //         color = PetColorType.Golden,
    //         breed = PetBreedType.Labrador,
    //     };

    //     return new List<Pet>{ newPet1, newPet2};
    // }
  }
}
