using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MoviesDto
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }

       

       
        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        public GenreDto Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Range(1, 20)]
      
        public byte NumberInStock { get; set; }
    }
}