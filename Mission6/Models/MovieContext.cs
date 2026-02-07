using Microsoft.EntityFrameworkCore;

namespace Mission6.Models;

public class MovieContext : DbContext
{
    // GET
    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {}
    
    public DbSet<Movie> Movies { get; set; }
}