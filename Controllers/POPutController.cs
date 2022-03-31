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

    public class PetOwnersPutController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetOwnersPutController(ApplicationContext context)
        {
            _context = context;
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, PetOwner petOwner)
        {
            Console.WriteLine("in PetOwner PUT");
            if (id != petOwner.id)
            {
                return BadRequest();
            }

            _context.Update(petOwner);
            _context.SaveChanges();

            return StatusCode(204);
        }




    }
}