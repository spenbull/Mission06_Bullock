namespace Mission06_Bullock.Models;
using Microsoft.EntityFrameworkCore;

public class AddMovieContext : DbContext
{
    public AddMovieContext(DbContextOptions<AddMovieContext> options) : base(options)
    {
        
    }
    
    public DbSet<Application> Applications { get; set; }
}