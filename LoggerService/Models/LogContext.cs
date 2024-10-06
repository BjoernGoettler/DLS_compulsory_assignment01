using Microsoft.EntityFrameworkCore;
namespace LoggerService.Models;

public class LogContext: DbContext
{
    public LogContext(DbContextOptions<LogContext> options) : base(options)
    {
    }
    
    public DbSet<Log> Logs { get; set; } = null!;
}