using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;

namespace Disney.API.Repositories
{
    public interface IPersonajes
    {
        Task<List<Personaje>> GetCharactersAsync();
        Task<Personaje> GetCharacterById(Guid id);
        Personaje AddCharacter(string nombrePersonaje, int edad, string historia, string imagenPersonaje, string titulo, int calificacion, DateTime fechaCreacion, string imagenPelicula);
        Personaje EditCharacter(Personaje personaje);
        void DeleteCharacter(Guid id);
        Task<bool> SaveChangesAsync();
    }
}
