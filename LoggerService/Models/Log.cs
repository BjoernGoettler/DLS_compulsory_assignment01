using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoggerService.Models;

public class Log
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Timestamp]
    public byte[] Timestamp { get; set; }
    public string LogLevel { get; set; }
    public string Message { get; set; }
}