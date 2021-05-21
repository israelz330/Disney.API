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

    }
}
