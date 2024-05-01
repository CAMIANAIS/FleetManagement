using FleetManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace MiProyecto.Controllers;

[ApiController]
[Route("api/autores")]
public class AutoresController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Taxi>> Get()
    {
        //Por ahora una lista estática hasta que creemos la bd
        return new List<Taxi>()
        {
            new Taxi { Id = 5391, Plate = "5Y58-95HU" },

        };
    }
}