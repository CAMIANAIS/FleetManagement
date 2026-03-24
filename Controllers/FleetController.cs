using FleetManagement.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace FleetManagement.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class FleetController : ControllerBase
    {
        private readonly IFleetService _fleetService;

        public FleetController(IFleetService fleetService)
        {
            _fleetService = fleetService;
        }

        [HttpGet("taxis")]
        public async Task<IActionResult> GetTaxis([FromQuery] string plate, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            pageNumber = Math.Max(1, pageNumber);
            pageSize = Math.Clamp(pageSize, 1, 100);

            var (items, totalCount) = await _fleetService.GetTaxisAsync(plate, pageNumber, pageSize);
            return Ok(new { Items = items, TotalCount = totalCount });
        }

        [HttpGet("trajectories")]
        public async Task<IActionResult> GetTrajectories([FromQuery] int taxiId, [FromQuery] DateTime date, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            pageNumber = Math.Max(1, pageNumber);
            pageSize = Math.Clamp(pageSize, 1, 100);

            var (items, totalCount) = await _fleetService.GetTrajectoriesAsync(taxiId, date, pageNumber, pageSize);
            return Ok(new { TaxiId = taxiId, Date = date.ToString("yyyy-MM-dd"), Items = items, TotalCount = totalCount });
        }

        [HttpGet("trajectories/latest")]
        public async Task<IActionResult> GetLatestLocations([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            pageNumber = Math.Max(1, pageNumber);
            pageSize = Math.Clamp(pageSize, 1, 100);

            var (items, totalCount) = await _fleetService.GetLatestLocationsAsync(pageNumber, pageSize);
            return Ok(new { Items = items, TotalCount = totalCount });
        }
    }
}