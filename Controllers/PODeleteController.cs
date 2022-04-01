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
    [Route("api/petowners")]
    public class PetOwnersDeleteController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetOwnerDeleteController(ApplicationContext context) {
            _context = context;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (int id){

          PetOwner petOwner = _context.PetOwners.SingleOrDefault(po => po.id == id);

          if (petOwner is null)
          {
            return NotFound();
          }

          _context.PetOwners.Remove(petOwner);
          _context.SaveChanges();

          return NoContent();


        }
    }
}