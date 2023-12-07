using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly DataContext _context;

        public ProfileController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetData()
        {
            var data = _context.Profiles
                .Include(p => p.Frameworks)
                .Include(p => p.Hobbies).FirstOrDefault();



            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpPut]
        public IActionResult UpdateData(Profile request)
        {
            if (request == null)
            {
                BadRequest();
            }



            Profile profile = _context.Profiles.Find(request!.Id)!;

            profile.Name = request!.Name;
            profile.Lastname = request!.Lastname;
            profile.Email = request!.Email;
            profile.City = request!.City;
            profile.Country = request!.Country;


            profile.Frameworks = request!.Frameworks;
            profile.Hobbies = request!.Hobbies;


            _context.SaveChanges();

            return Ok(profile);
        }
    }
}