using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Player.Service.Models;

namespace Player.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(new PlayerEntity
            {
                FirstName = "Jayant",
                LastName = "Babu",
                Email = "jbabu@gmail.com",
                ImageUrl = "http://jayant",
                MobileNumber = 994455112255,
                PersonalInformation = "Avid badminton player and cyclist",
                PlayerId = id
            });
        }
    }
}
