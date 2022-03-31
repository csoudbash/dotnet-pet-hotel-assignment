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
    public class PetsPostController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetsPostController(ApplicationContext context) {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(Pet pet){
          _context.Add(pet);
          _context.SaveChanges();
          return CreatedAtAction(nameof(Post),
                                     new {id = pet.id}, pet);


        }
    }
}