using FleetManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace MiProyecto.Controllers;

[ApiController]
[Route("[controller]")]
public class TaxisController : ControllerBase
{
    private readonly ITaxiService _taxiService;

    public TaxisController(ITaxiService taxiService)
    {
        _taxiService = taxiService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Taxi>> GetTaxis(int page = 1, int pageSize = 10)
    {
        var taxis = _taxiService.GetTaxis(page, pageSize);
        return Ok(taxis);
    }
}
