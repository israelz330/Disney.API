using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Disney.API.Repositories
{
    public class SqlDisneyCharacters : IPersonajes
    {
        private readonly DisneyContext _dbContext;

        public SqlDisneyCharacters(DisneyContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Character>> GetCharactersAsync()
        {
            List<Character> listOfCharacters = new();

            var query = from personajes in _dbContext.Personajes select personajes;

            foreach (var personaje in query)
            {
                listOfCharacters.Add(new Character()
                {
                    Name = personaje.Nombre,
                    Image = personaje.Imagen
                });
            }

            return listOfCharacters;
        }

        public async Task<Personaje> GetCharacterById(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return await _dbContext.Personajes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Personaje AddCharacter(string nombrePersonaje, int edad, string historia, string imagenPersonaje, string titulo, int calificacion, DateTime fechaCreacion, string imagenPelicula)
        {
            var personaje = new Personaje
            {
                Id = new Guid(), 
                Nombre = nombrePersonaje,
                Edad = edad,
                Historia = historia,
                Imagen = imagenPersonaje,
                Peliculas = new List<Pelicula>()
                {
                    new Pelicula()
                    {
                        Id = new Guid(),
                        Titulo = titulo,
                        Calificacion = calificacion,
                        FechaCreacion = fechaCreacion,
                        Imagen = imagenPelicula,
                        Personajes = new List<Personaje>()
                        {
                        }
                    },
                }
            };

            _dbContext.Personajes.Add(personaje);

            return personaje;
        }

        public Personaje EditCharacter(Personaje personaje)
        {
            var existingCharacter = _dbContext.Personajes.Find(personaje.Id);

            if (existingCharacter == null) return personaje;

            existingCharacter.Nombre = personaje.Nombre;
            existingCharacter.Edad = personaje.Edad;
            existingCharacter.Historia = personaje.Historia;
            existingCharacter.Imagen = personaje.Imagen;

            _dbContext.Personajes.Update(existingCharacter);

            return personaje;
        }

        public void DeleteCharacter(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
