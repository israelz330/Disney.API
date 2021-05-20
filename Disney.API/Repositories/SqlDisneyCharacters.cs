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
        public async Task<List<Personaje>> GetCharactersAsync()
        {
            return await _dbContext.Personajes.ToListAsync();
        }

        public async Task AddCharacterAsync(Personaje personaje)
        {
            throw new NotImplementedException();
        }

        public async Task EditCharacterAsync(Personaje personaje)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteCharacterAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
