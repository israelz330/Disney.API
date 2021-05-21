using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Models;

namespace Disney.API.Repositories
{
    public class SqlDisneyGenres : IGeneros
    {
        private readonly DisneyContext _dBContext;

        public SqlDisneyGenres(DisneyContext dBContext)
        {
            _dBContext = dBContext;
        }

        public Genero AddGenre(Genero genero)
        {
            _dBContext.Generos.Add(genero);
            return genero;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _dBContext.SaveChangesAsync() > 0;
        }
    }
}
