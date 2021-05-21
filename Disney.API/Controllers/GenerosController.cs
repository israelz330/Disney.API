using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using Disney.API.Repositories;

namespace Disney.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        private readonly IGeneros _generos;

        public GenerosController(IGeneros generos)
        {
            _generos = generos;
        }

        /// <summary>
        /// Añade un nuevo género.
        /// </summary>
        /// <param name="genero"></param>
        /// <returns>Género</returns>
        [Route("api/addGenre")]
        [HttpPost]
        public async Task AddGenre(Genero genero)
        {
             _generos.AddGenre(genero);

             await _generos.SaveChangesAsync();
        }


    }
}
