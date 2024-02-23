using System.ComponentModel.DataAnnotations;
namespace Mission06_Tait.Models

//make the Categories Model and make the CategoryID the primary key
{
    public class Categories
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
