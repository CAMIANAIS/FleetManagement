namespace FleetManagement.Entities
{
    public class Taxi
    {
        public int id { get; set; }
        public string plate { get; set; }

        public ICollection<Trajectory> Trajectories { get; set; }
    }

}
