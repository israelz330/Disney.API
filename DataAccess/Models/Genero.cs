using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Genero
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Imagen { get; set; }
        [Required]
        public ICollection<Pelicula> Peliculas { get; set; }
    }
}