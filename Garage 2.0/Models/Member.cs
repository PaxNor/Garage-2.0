namespace Garage_2._0.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersNr { get; set; }

        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}
