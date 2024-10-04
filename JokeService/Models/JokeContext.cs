using Microsoft.EntityFrameworkCore;
namespace JokeService.Models;

public class JokeContext: DbContext
{
    public JokeContext(DbContextOptions<JokeContext> options) : base(options)
    {
    }
    
    public DbSet<Joke> Jokes { get; set; } = null!;
    
}