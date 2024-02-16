using Microsoft.EntityFrameworkCore;

namespace Mission06_Tait.Models
{
    public class EnterMoviesContext : DbContext
    {
        public EnterMoviesContext(DbContextOptions<EnterMoviesContext>options) : base (options) //constructor
        { 
        } 

        public DbSet<Movie> Movies { get; set; }
    }


}
