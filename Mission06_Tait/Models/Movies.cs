using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Tait.Models
{
    //make the model for Movies and make Category ID the foreign key and Movie ID the primary key
    public class Movies
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryID")]
        public int? CategoryId { get; set; }
        public Categories? Category { get; set; }

        [Required(ErrorMessage = "Sorry, you need to enter a title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Sorry, you need to enter a year.")]
        [Range(1888, int.MaxValue, ErrorMessage = "You must enter a valid year.")]
        public int Year { get; set; }

        public string ? Director { get; set; }

        public string ? Rating { get; set; }

        [Required(ErrorMessage = "Sorry, you need to specify if the movie was edited.")]
        public bool Edited { get; set; }

        public string ? LentTo { get; set; }

        [Required(ErrorMessage= "Please select yes or no for Copied to Plex")]
        public int CopiedToPlex { get; set; }

        [MaxLength(25, ErrorMessage ="Please have it be 25 letters or less")]
        public string ? Notes { get; set; }
    }

}
