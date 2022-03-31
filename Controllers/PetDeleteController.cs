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
    public class PetsDeleteController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetsDeleteController(ApplicationContext context) {
            _context = context;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (int id){

          Pet pet = _context.Pets.SingleOrDefault(p => p.id == id);

          if (pet is null)
          {
            return NotFound();
          }

          _context.Pets.Remove(pet);
          _context.SaveChanges();

          return NoContent();


        }
    }
}