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
    public async Task<IActionResult> GetTaxisAsync()
    {
        return Ok(await _context.Taxis.ToListAsync());
    }
}