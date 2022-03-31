using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;




namespace pet_hotel.Controllers
{
    [ApiController]
    [Route("api/pets")]
    public class PetsPutController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetsPutController(ApplicationContext context) {
            _context = context;
        }

    [HttpPut("{id}")]
        public IActionResult Put(int id, Pet pet){
          if (id != pet.id)
          {
            return BadRequest();
          }
          _context.Update(pet);
          _context.SaveChanges();

          return NoContent();
}
    }
}
