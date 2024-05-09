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
        public async Task<IActionResult> GetTrajectoriesAsync()
        {
            List<Trajectory> trajectories = await _context.Trajectories.ToListAsync();
            return Ok(trajectories);
        }
    }

}
