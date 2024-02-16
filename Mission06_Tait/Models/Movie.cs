using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Mission06_Tait.Models
{
    //make the model
    public class Movie
    {
        [Key]
        [Required]
        public required int MovieID { get; set; }
        public required string Category { get; set; }
        public required string Title { get; set; }
        public required string Year { get; set; }
        public required string Director { get; set; }
        public required string Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; } 
    }
}

