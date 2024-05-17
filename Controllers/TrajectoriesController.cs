using FleetManagement.Data;
using FleetManagement.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MiProyecto.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TrajectoriesController : ControllerBase
    {
        private readonly DataContext _context;

        public TrajectoriesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetLocationsByTaxiAndDate(int taxiId, DateTime date, int pageNumber = 1, int pageSize = 10)
        {
            var query = _context.Trajectories
                .Where(t => t.taxi_id == taxiId && t.date.Date == date.Date)
                .Select(t => new
                {
                    t.latitude,
                    t.longitude,
                    timestamp = t.date
                });

            var totalCount = await query.CountAsync();
            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Ok(new
            {
                taxiId,
                date = date.Date,
                items,
                totalCount
            });
        }
        [HttpGet]
        public async Task<IActionResult> GetLatestLocations(int pageNumber = 1, int pageSize = 10)
        {
            var query = _context.taxis
                .Select(t => new
                {
                    t.id,
                    t.plate,
                    LatestTrajectory = t.Trajectories
                        .OrderByDescending(tr => tr.date)
                        .FirstOrDefault()
                })
                .Where(t => t.LatestTrajectory != null)
                .Select(t => new
                {
                    t.id,
                    t.plate,
                    t.LatestTrajectory.latitude,
                    t.LatestTrajectory.longitude,
                    timestamp = t.LatestTrajectory.date
                });

            var totalCount = await query.CountAsync();
            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Ok(new
            {
                items,
                totalCount
            });
        }
    }
}
    
    
