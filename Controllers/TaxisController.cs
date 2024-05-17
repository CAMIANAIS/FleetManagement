using FleetManagement.Data;
using FleetManagement.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MiProyecto.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class TaxisController : ControllerBase

{
    private readonly DataContext _context;

    public TaxisController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetTaxisAsync(int pageNumber = 1, int pageSize = 10)
    {
        var query = _context.taxis
            .Select(t => new { id = t.id, plate = t.plate });
        var totalCount = await query.CountAsync();
        var items = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        return Ok(new { items, totalCount });
    }
}