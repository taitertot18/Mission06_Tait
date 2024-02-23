using Microsoft.EntityFrameworkCore;

namespace Mission06_Tait.Models
{
    public class JoelHiltonMovieCollectionContext : DbContext
    {
        public JoelHiltonMovieCollectionContext(DbContextOptions<JoelHiltonMovieCollectionContext> options) : base(options) //constructor
        {
        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Categories> Categories { get; set; }

    }

}

