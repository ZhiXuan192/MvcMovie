using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Review
    {

        public int Id { get; set; }
        
        [Required]
        public int MovieId { get; set; }

        public List<Movie>? Movies { get; set; }
 

        [Required]
        [StringLength(100)]
        public string? UserName { get; set; }

        [Required]
        [StringLength(1000)]
        public string? Content { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public DateTime PostedAt { get; set; } = DateTime.UtcNow;
    }
}