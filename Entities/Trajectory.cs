namespace FleetManagement.Entities
{
    public class Trajectory
    {
        public int id { get; set; }
        public int taxi_id { get; set; }
        public DateTime date { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }

        public Taxi Taxi { get; set; }
    }
}
