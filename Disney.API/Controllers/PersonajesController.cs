using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccess.Context;
using DataAccess.Models;
using Disney.API.Repositories;

namespace Disney.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajesController : ControllerBase
    {
        private readonly IPersonajes _personajes;

        public PersonajesController(IPersonajes personajes)
        {
            _personajes = personajes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("characters")]
        [HttpGet]
        public async Task<IActionResult> GetAllCharacters()
        {
            return Ok(await _personajes.GetCharactersAsync());
        }

    }
}
