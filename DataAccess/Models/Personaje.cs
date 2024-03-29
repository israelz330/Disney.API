﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Personaje
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public double Peso { get; set; }
        [Required]
        public string Historia { get; set; }
        [Required]
        public string Imagen { get; set; }
        [Required]
        public ICollection<Pelicula> Peliculas { get; set; }
    }
}
