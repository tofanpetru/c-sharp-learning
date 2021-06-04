using Microsoft.AspNetCore.Mvc;
using Persistence;
using Repository;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FlightApi.Controller
{
    [Route("api")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FlightController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: api/Flight/5
        [HttpGet("[controller]/{id}")]
        public async Task<ActionResult<Flight>> GetFlight(int id)
        {
            var flight = await _context.Flights.FindAsync(id);

            return flight;
        }

        // GET: api/Flight
        [HttpGet("[controller]")]
        public async Task<ActionResult<IEnumerable<Flight>>> GetFlights()
        {
            return await _context.Flights.ToListAsync();
        }

        [HttpGet("{flightid}")]
        public async Task<ActionResult<Flight>> GetPrimitive([FromQuery] int flightid)
        {

            var flight = await _context.Flights.FindAsync(flightid);

            return flight;
        }

        [HttpPost]
        public async Task<ActionResult<Flight>> PostFlight(Flight flight)
        {
            _context.Flights.Add(flight);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFlight", new { id = flight.FlightId }, flight);
        }
    }
}
