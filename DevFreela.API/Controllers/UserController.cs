using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        public UserController(ExampleClass exampleClass)
        {

        }
        // api/users/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //obter usuarios por perfil
            return Ok();
        }

        // api/users
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel createUserModel)
        {
           
            return CreatedAtAction(nameof(GetById), new { id = 1}, createUserModel);
        }

        // api/users/1/login
        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginModel login)
        {
            return NoContent();
        }

    }
}
