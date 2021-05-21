using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;

namespace Disney.API.Repositories
{
    public interface IGeneros
    {
        Genero AddGenre(Genero genero);
        Task<bool> SaveChangesAsync();
    }
}
