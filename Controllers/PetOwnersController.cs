using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace pet_hotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetOwnersController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetOwnersController(ApplicationContext context) {
            _context = context;
        }

        // This is just a stub for GET / to prevent any weird frontend errors that 
        // occur when the route is missing in this controller
        [HttpGet]
        public IEnumerable <PetOwner> GetAll() {
            Console.WriteLine("getting all pet owners");
            // return new List<PetOwner>();
            return _context.PetOwners;
        }

        [HttpPost]
        public IActionResult Post(PetOwner petowner) {
            _context.Add(petowner);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Post), new { id = petowner.id}, petowner );
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            PetOwner petowner = _context.PetOwners.SingleOrDefault(p => p.id == id);
            if (petowner is null)
            {
                return NotFound();
            }

            _context.PetOwners.Remove(petowner);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, PetOwner petowner) {
            Console.WriteLine("in PUT");
            if( id != petowner.id) {
                return BadRequest();
            }

            _context.Update(petowner);
            _context.SaveChanges();

            return NoContent();

        }
    }

    



    
}
