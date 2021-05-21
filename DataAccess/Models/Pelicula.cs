using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Pelicula
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "El título de la película no puede superar los 50 caracteres.")] 
        public string Titulo { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "la calificación debe ser entre 1 y 5")]  
        public int Calificacion { get; set; }
        [Required]
        public string Imagen { get; set; }
        [Required]
        public ICollection<Personaje> Personajes { get; set; }
    }
}