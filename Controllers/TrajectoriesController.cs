using FleetManagement.Data;
using FleetManagement.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FleetManagement.Controllers
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
            var searchDate = date.ToUniversalTime().Date;

            var query = _context.trajectories
                .Where(t => t.taxiid == taxiId && t.date.Date == searchDate.Date)
                .Select(t => new
                {
                    t.latitude,
                    t.longitude,
                    Timestamp = t.date
                });

            var totalCount = await query.CountAsync();
            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Ok(new
            {
                TaxiId = taxiId,
                Date = date.ToString("dd/MM/yyyy"),
                Items = items,
                TotalCount = totalCount
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
                    Timestamp = t.LatestTrajectory.date
                });

            var totalCount = await query.CountAsync();
            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Ok(new
            {
                Items = items,
                TotalCount = totalCount
            });
        }
    }
}
    
    
