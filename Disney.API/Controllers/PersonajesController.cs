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
        /// Enlista todos los personajes (Nombre, Imagen).
        /// </summary>
        /// <returns>Nombre e imagen</returns>
        [Route("characters")]
        [HttpGet]
        public async Task<IActionResult> GetAllCharacters()
        {
            return Ok(await _personajes.GetCharactersAsync());
        }

        /// <summary>
        /// Añade un nuevo personaje al mundo de Disney
        /// </summary>
        /// <param name="nombrePersonaje"></param>
        /// <param name="edad"></param>
        /// <param name="historia"></param>
        /// <param name="imagenPersonaje"></param>
        /// <param name="titulo"></param>
        /// <param name="calificacion"></param>
        /// <param name="fechaCreacion"></param>
        /// <param name="imagenPelicula"></param>
        /// <returns></returns>
        [Route("addCharacters")]
        [HttpPost]
        public async Task<IActionResult> AddCharacter(string nombrePersonaje, int edad, string historia, string imagenPersonaje, string titulo, int calificacion, DateTime fechaCreacion, string imagenPelicula)
        {
            var personaje = new Personaje();

            if (personaje.Nombre == null)  NotFound("No puedes dejar sin nombre al personaje!");

            _personajes.AddCharacter(nombrePersonaje, edad, historia, imagenPersonaje, titulo, calificacion, fechaCreacion, imagenPelicula);

            await _personajes.SaveChangesAsync();

            return Ok();
        }

        /// <summary>
        /// Edita al personaje de Disney
        /// </summary>
        /// <param name="id"></param>
        /// <param name="personaje"></param>
        /// <returns></returns>
        [Route("editCharacter/{id}")]
        [HttpPatch]
        public async Task<IActionResult> EditCharacter(Guid id, Personaje personaje)
        {
            var existingCharacter = await _personajes.GetCharacterById(id);

            if (existingCharacter != null)
            {
                personaje.Id = existingCharacter.Id;
                _personajes.EditCharacter(personaje);
                await _personajes.SaveChangesAsync();
                return Ok();
            }

            return NotFound("ERROR, NOT FOUND :(");
        }
    }
}
