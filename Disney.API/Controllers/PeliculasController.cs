using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Disney.API.Repositories;

namespace Disney.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private readonly IPeliculas _peliculas;
        public PeliculasController(IPeliculas peliculas)
        {
            peliculas = _peliculas;
        }

        /// <summary>
        /// Enlista todas las películas de Disney
        /// </summary>
        /// <returns>Películas de Disney</returns>
        [Route("GetMovies")]
        [HttpGet]
        public async Task<IActionResult> GetDisneyMovies()
        {
            if (await _peliculas.GetAllMovies() != null)
            {
                return Ok();
            }
            else
            {
                return NotFound("No movies in the database");
            }
        }


    }
}
