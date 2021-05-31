using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Disney.API.Repositories
{
    public class SqlDisneyMovies :IPeliculas
    {
        private readonly DisneyContext _dbContext;

        public SqlDisneyMovies(DisneyContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Pelicula>> GetAllMovies()
        {
            return await _dbContext.Peliculas.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
