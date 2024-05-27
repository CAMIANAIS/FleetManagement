using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FleetManagement.Entities
{
    public class Trajectory
    {

        public int idtrajectories { get; set; }

        public int taxiid { get; set; }

        public DateTime date { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }

        // Propiedad de navegación para la relación con Taxi
        public Taxi Taxi { get; set; }
    }
}
