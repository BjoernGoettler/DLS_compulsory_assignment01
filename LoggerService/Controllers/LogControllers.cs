using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LoggerService.Models;

namespace LoggerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogControllers : ControllerBase
    {
        private readonly LogContext _context;

        public LogControllers(LogContext context)
        {
            _context = context;
        }

        // GET: api/LogControllers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Log>>> GetLogs()
        {
            return await _context.Logs.ToListAsync();
        }

        // GET: api/LogControllers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Log>> GetLog(int id)
        {
            var log = await _context.Logs.FindAsync(id);

            if (log == null)
            {
                return NotFound();
            }

            return log;
        }

        // POST: api/LogControllers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Log>> PostLog(LogInDto logdto)
        {
            Log log = new Log()
            {
                Timestamp = DateTime.Now,
                LogLevel = logdto.LogLevel,
                LogMessage = logdto.LogMessage,
            };
            _context.Logs.Add(log);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLog", new { id = log.Id }, log);
        }

        // DELETE: api/LogControllers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLog(int id)
        {
            var log = await _context.Logs.FindAsync(id);
            if (log == null)
            {
                return NotFound();
            }

            _context.Logs.Remove(log);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LogExists(int id)
        {
            return _context.Logs.Any(e => e.Id == id);
        }
    }
}
