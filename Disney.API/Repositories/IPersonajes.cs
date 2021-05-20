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
        Task AddCharacterAsync(Personaje personaje);
        Task EditCharacterAsync(Personaje personaje);
        Task DeleteCharacterAsync(int id);

    }
}
